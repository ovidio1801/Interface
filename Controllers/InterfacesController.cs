
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

        public InterfacesController(RRHHContext context)
        {
            ctx = context;
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

        public IActionResult Aceptar(string option)
        {


            if (option == "1")//Asientos Contables
            {
                AsientoEnc Enc = ctx.AsientoEncs.ToList().FirstOrDefault();

                string ca_empresa = Enc.ca_empresa.ToString();
                string ca_cod_geografico = Enc.ca_cod_geografico.ToString();
                string ca_cod_contab = Enc.ca_cod_contab.ToString();
                string ca_cod_comp1 = Enc.ca_cod_comp1.ToString();
                string ca_anio_trans = Enc.ca_anio_trans.ToString();
                decimal ca_cod_per = Enc.ca_cod_per;
                string cal_run_id = Enc.cal_run_id.ToString();

                List<AsientoDet> Det = new List<AsientoDet>();

                //Det = ctx.AsientoDets.Take(5).ToList();

                Det = ctx.AsientoDets.Where(x => x.ca_empresa == ca_empresa
                    && x.ca_cod_geografico == ca_cod_geografico && x.ca_cod_contab == ca_cod_contab
                    && x.ca_cod_comp1 == ca_cod_comp1 && x.ca_anio_trans == ca_anio_trans
                    && x.ca_cod_per == ca_cod_per && x.cal_run_id == cal_run_id)
                    .ToList();
                ViewBag.Enc = Enc;
                return View("AsientosContables", Det);
            }


            return StatusCode(200, "Todo fue bien");
        }
        public IActionResult AsientosContables(AsientoEnc Enc)
        {

            string[] _user = HttpContext.User.Identity.Name.ToString().Split(@"\");

            string strSql = "Exec USP_CA_ASIENTO {0}, {1}";
            ctx.Database.ExecuteSqlRaw(strSql, 1, _user[1]);

            return View("Index");
        }
    }
}
