
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using RRHH.Data;
using Microsoft.EntityFrameworkCore;
using RRHH.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace RRHH.Controllers
{
    public class InterfacesController : Controller
    {

        private readonly RRHHContext ctx;
        private readonly ContabContext ctxContab;

        public InterfacesController(RRHHContext context, ContabContext contContext)
        {
            ctx = context;
            ctxContab = contContext;
        }

        public IActionResult Index()
        {
            string[] _user = HttpContext.User.Identity.Name.ToString().Split(@"\");

            string strSql = "Exec USP_CA_ACREDITACION {0}, {1}";
            ctx.Database.ExecuteSqlRaw(strSql, 0, _user[1]);

            strSql = "Exec USP_CA_ROL_DESCUENTO {0}, {1}";
            ctx.Database.ExecuteSqlRaw(strSql, 0, _user[1]);

            strSql = "Exec USP_CA_ASIENTO {0}, {1}";
            ctx.Database.ExecuteSqlRaw(strSql, 0, _user[1]);

            strSql = "Exec USP_CA_ACRED_BENEFICIO {0}, {1}";
            ctx.Database.ExecuteSqlRaw(strSql, 0, _user[1]);


            return View("Index");
        }

        public IActionResult ShowOption(string option)
        {


            if (option == "1")//Asientos Contables
            {
                List<AsientoEnc> Encs = ctx.AsientosEnc.Where(x => x.ca_pasado == "N").ToList();

                if(Encs != null)
                {
                    return View("AsientosEnc", Encs);
                }

                return NotFound("No se encontraron Asientos contables");
            }


            return StatusCode(200, "Todo fue bien");
        }

        public IActionResult DetalleAS(string ca_empresa, string ca_cod_geografico, string ca_cod_contab, string ca_cod_comp1,
            string ca_anio_trans, decimal ca_cod_per, string cal_run_id)
        {
            
            
            
            //string ca_empresa = Enc.ca_empresa.ToString();
            //string ca_cod_geografico = Enc.ca_cod_geografico.ToString();
            //string ca_cod_contab = Enc.ca_cod_contab.ToString();
            //string ca_cod_comp1 = Enc.ca_cod_comp1.ToString();
            //string ca_anio_trans = Enc.ca_anio_trans.ToString();
            //decimal ca_cod_per = Enc.ca_cod_per;
            //string cal_run_id = Enc.cal_run_id.ToString();

            List<AsientoDet> Dets = new List<AsientoDet>();

            ////Det = ctx.AsientoDets.Take(5).ToList();

            Dets = ctx.AsientosDet.Where(x => x.ca_empresa == ca_empresa
                && x.ca_cod_geografico == ca_cod_geografico && x.ca_cod_contab == ca_cod_contab
                && x.ca_cod_comp1 == ca_cod_comp1 && x.ca_anio_trans == ca_anio_trans
                && x.ca_cod_per == ca_cod_per && x.cal_run_id == cal_run_id)
                .ToList();

            return PartialView("_modalDetalle", Dets);
        }


        public IActionResult ProcesarAS(AsientoEnc Enc)
        {

            //string SQL = "SELECT B.seq_comp  ,C.seq_comp ,B.COD_EJER ,C.COD_PER 	INTO    	:ll_COMP_EJE,:ll_COMP_PER,:ll_cod_ejer,:ll_COD_PER
            //                FROM TEST_CONTA.DBO.CN_SEQEJER B, TEST_CONTA.DBO.CN_SEQPER C
            //                WHERE B.COD_EJER = C.COD_EJER AND B.COD_COMP = C.COD_COMP AND
            //                B.COD_COMP = '01' and B.COD_EJER = :ll_anio and
            //                C.COD_PER = :ll_periodo;


            string[] _user = HttpContext.User.Identity.Name.ToString().Split(@"\");

            string strSql = "Exec USP_CA_ASIENTO {0}, {1}";
            ctx.Database.ExecuteSqlRaw(strSql, 1, _user[1]);

            return View("Index");
        }
    }
}
