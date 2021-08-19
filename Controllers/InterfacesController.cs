
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using RRHH.Data;
using Microsoft.EntityFrameworkCore;
using RRHH.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.Extensions.Configuration;
using System.Data.Odbc;
using Microsoft.AspNetCore.Authorization;

namespace RRHH.Controllers
{
    [Authorize(Policy = "CubitosUsers")]
    public class InterfacesController : Controller
    {

        private readonly RRHHContext ctx;
        private readonly ContabContext ctxContab;
        private IConfiguration config;

        public InterfacesController(RRHHContext context, ContabContext contContext, IConfiguration _config)
        {
            ctx = context;
            ctxContab = contContext;
            config = _config;
        }

        public IActionResult Index()
        {
            string[] _user = new string[]{"",""};
            
            if(HttpContext.User.Identity.Name != null){
                _user = HttpContext.User.Identity.Name.ToString().Split(@"\");
            }

            // string _domainUser = HttpContext.User.Identity.Name;

            // string[] _user = _domainUser.Split(@"\");

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

            if (option == "2")//Acreditación de Salarios
            {
                List<AcreditacionEmpleado> acreds = ctx.AcredsEmpl.Where(x => x.ca_estatus=="P" && !x.ca_tp_pago.StartsWith("BE")).ToList();

                if (acreds != null)
                {
                   return View("AcredsEmpl", acreds);
                }

                return NotFound("No se encontraron Acreditaciones");
            }

            if (option == "3")//Productos Internos
            {
                //Ovidio 2021-ago-9: se comenta por que está dando timeout
                //List<DescuentoProducto> prods = null;
                List<DescuentoProducto> prods = ctx.DescsProd.Where(x => x.ca_estatus == "P").ToList();
                List<DescuentoTarjeta> tars = ctx.DescsTar.Where(x => x.ca_estatus == "P").ToList();

                ViewBag.tars = tars;

                return View("ProductosInternos", prods);  
            }

            if (option == "4")//Cheques IBS
            {
                
                List<Cheque> cheques = ctx.Cheques.Where(x => x.status == "I").ToList();

                return View("ChequesIBS", cheques);  
            }

            if (option == "5")//Acreditación de Beneficios
            {
                
                List<AcreditacionEmpleado> acreds = ctx.AcredsEmpl.Where(x => x.ca_estatus == "P").ToList();

                return View("AcredBenef", acreds);  
            }

            return StatusCode(200, "Todo fue bien");
        }

        public IActionResult DetalleAS(string ca_empresa, string ca_cod_geografico, string ca_cod_contab, string ca_cod_comp1,
            string ca_anio_trans, decimal ca_cod_per, string cal_run_id)
        {
            
            List<AsientoDet> Dets = new List<AsientoDet>();


            Dets = ctx.AsientosDet.Where(x => x.ca_empresa == ca_empresa
                && x.ca_cod_geografico == ca_cod_geografico && x.ca_cod_contab == ca_cod_contab
                && x.ca_cod_comp1 == ca_cod_comp1 && x.ca_anio_trans == ca_anio_trans
                && x.ca_cod_per == ca_cod_per && x.cal_run_id == cal_run_id)
                .ToList();

            return PartialView("_modalDetalle", Dets);
        }


        public IActionResult ProcesarAS(List<AsientoEnc> model)
        {

            List<string> Errores = new List<string>();

            if(model.Count < 1)
            {
                Errores.Add("No hay asientos que procesar");
                ViewBag.Errores = Errores;
                return View("AsientosEnc", model);
            }

            try
            {
                ctx.Database.BeginTransaction();

                for (int i=0; i<model.Count(); i++)
                {
                    string anio_trans = model[i].ca_anio_trans.ToString();
                    int cod_per = (int)model[i].ca_cod_per;
                    Periodo per = ctxContab.Periodos.Where(x => x.cod_ejer == anio_trans && x.cod_per == cod_per).SingleOrDefault();

                    if (per != null)
                    {
                        int comp_ejer = per.comp_eje;
                        int comp_per = per.comp_per + 1;
                        string ca_empresa = model[i].ca_empresa;
                        string ca_cod_geografico = model[i].ca_cod_geografico;
                        string ca_cod_contab = model[i].ca_cod_contab;
                        string ca_cod_comp1 = model[i].ca_cod_comp1;
                        decimal ca_anio_trans = model[i].ca_anio_trans;
                        decimal ca_cod_per = model[i].ca_cod_per;
                        DateTime ca_fec_asiento = model[i].ca_fec_asiento;
                        string cal_run_id = model[i].cal_run_id;



                        string sql = "Update ps_ca_rol_cn_asientos set ca_num_comp_eje = {0}, ca_num_comp_per = {1} ";
                        sql += "from ps_ca_rol_cn_asientos where ca_empresa = {2} and ca_cod_geografico = {3} ";
                        sql += "and ca_cod_contab = {4} and ca_cod_comp1 = {5} and ca_anio_trans = {6} and ca_cod_per = {7} ";
                        sql += "and ca_fec_asiento = {8} and cal_run_id = {9}";

                        int rows = ctx.Database.ExecuteSqlRaw(sql, comp_ejer, comp_per, ca_empresa, ca_cod_geografico,
                            ca_cod_contab, ca_cod_comp1, ca_anio_trans, ca_cod_per, ca_fec_asiento, cal_run_id);

                        sql = "Update ps_ca_rol_cn_movim set ca_num_comp_eje = {0}, ca_num_comp_per = {1} ";
                        sql += "from ps_ca_rol_cn_movim where ca_empresa = {2} and ca_cod_geografico = {3} ";
                        sql += "and ca_cod_contab = {4} and ca_cod_comp1 = {5} and ca_anio_trans = {6} and ca_cod_per = {7} ";
                        sql += "and cal_run_id = {8}";

                        rows = ctx.Database.ExecuteSqlRaw(sql, comp_ejer, comp_per, ca_empresa, ca_cod_geografico,
                        ca_cod_contab, ca_cod_comp1, ca_anio_trans, ca_cod_per, cal_run_id);

                        sql = "Update cn_seqper set seq_comp = seq_comp + 1 ";
                        sql += "from cn_seqper where cod_comp = '01' ";
                        sql += "and cod_ejer = {0} and cod_per = {1} ";

                        rows = ctxContab.Database.ExecuteSqlRaw(sql, anio_trans, cod_per);
                    }
                    else
                    {
                        throw new Exception("No existe año fiscal " + anio_trans + " ni periodo contable " + cod_per);
                    }

                }
               
                string[] _user = HttpContext.User.Identity.Name.ToString().Split(@"\");

                string strSql = "Exec USP_CA_ASIENTO {0}, {1}";
                ctx.Database.ExecuteSqlRaw(strSql, 1, _user[1]);

                string sql1 = "Update ps_ca_rol_cn_asientos set ca_pasado = 'S' ";
                sql1 += "from ps_ca_rol_cn_asientos where ca_pasado = 'N'";

                int rows1 = ctx.Database.ExecuteSqlRaw(sql1);

                ctx.Database.CommitTransaction();
                
            }

            catch (Exception Exception)
            {
                ctx.Database.RollbackTransaction();
                Errores.Add(Exception.Message);
                ViewBag.Errores = Errores;
                return View("AsientosEnc", model);
            }
            List<AsientoEnc> Encs = ctx.AsientosEnc.Where(x => x.ca_pasado == "N").ToList();
            ViewBag.Mensaje = "Se procesaron los Asientos con éxito!";
            return View("AsientosEnc", Encs);
        }


        public IActionResult ProcesarAE(List<AcreditacionEmpleado> model){

            List<string> Errores = new List<string>();

            if(model == null){
                Errores.Add("No existen acreditaciones para procesar!");
                ViewBag.Errores = Errores;
                return View("AcredsEmpl", model);
            }

            string lsNombre = config.GetValue<string>("LinkedServers:IBS:Nombre");
            string servidor = config.GetValue<string>("LinkedServers:IBS:Servidor");
            string esquema = config.GetValue<string>("LinkedServers:IBS:Esquema");

            try
            {
                //Ovidio 5-ago-2021: Se comenta mientras terminan pruebas del otro grupo
                ctx.Database.BeginTransaction();
                    string[] _user = HttpContext.User.Identity.Name.ToString().Split(@"\");
                    string strSql = "Exec USP_CA_ACREDITACION {0}, {1}";
                    ctx.Database.ExecuteSqlRaw(strSql, 1, _user[1]);

                    string sql = "UPDATE PS_CA_ROL_ACRED_EMPL SET CA_ESTATUS = 'A' ";
                    sql += "FROM " + lsNombre + "." + servidor + "." + esquema + ".INPAS inp, dbo.PS_CA_ROL_ACRED_EMPL acr ";
                    sql += "Where inp.ipgacc = acr.CA_CTA_ACRE ";
                    sql += "and ACR.ca_fec_pago =CONVERT(datetime,cast (inp.ipgvdm as CHAR(2)) + '/' + cast(inp.ipgvdd as CHAR(2)) + '/' + cast(inp.ipgvdy as CHAR(2)) ) ";
                    sql += "and acr.CA_MONTO_PG = inp.ipgcr1 ";
                    sql += "and acr.CA_ESTATUS = 'P' ";

                    int rows = ctx.Database.ExecuteSqlRaw(sql);
                ctx.Database.CommitTransaction();
            }
            catch (Exception ex)
            {
                ctx.Database.RollbackTransaction();
                Errores.Add("Ocurrio un error en el porceso de Acreditaciones!");
                Errores.Add(ex.Message);
                ViewBag.Errores = Errores;
                return View("AcredsEmpl", model);
            }

            List<AcreditacionEmpleado> acreds = ctx.AcredsEmpl.Where(x => x.ca_estatus=="P" && !x.ca_tp_pago.StartsWith("BE")).ToList();
            ViewBag.Mensaje = "Se han procesado las Acreditaciones con éxito!";
            return View("AcredsEmpl",acreds);
        }

        public IActionResult LoginPI(string usuario, string clave){

            
            return View("LoginPI");
        }

        public IActionResult ProductosInternos(string usuario, string clave){

            List<string> Errores = new List<string>();
            
            string DSN = config.GetValue<string>("ODBC:DSN");
            string conStr= "DSN=" + DSN + "; UID=" + usuario.Trim() +"; PWD=" + clave.Trim() + ";";
             
            
            OdbcConnection con = new OdbcConnection(conStr);
            
            try
            {
                if(con != null || con.State == System.Data.ConnectionState.Closed){
                con.Open();
                con.Close();
                ctx.Database.BeginTransaction();
                    
                    string sql = "UPDATE PS_CA_ROL_DESCUEN_PROD SET CA_USUARIO_IBS = {0} ";
                    sql += "WHERE CA_ESTATUS = 'P' ";
                    int rows = ctx.Database.ExecuteSqlRaw(sql, usuario);

                    string[] _user = HttpContext.User.Identity.Name.ToString().Split(@"\");
                    string strSql = "Exec USP_CA_ROL_DESCUENTO {0}, {1}";
                    ctx.Database.ExecuteSqlRaw(strSql, 1, _user[1]);

                    string sql1 = "UPDATE PS_CA_ROL_DESCUEN_PROD SET CA_ESTATUS = 'C' ";
                    sql1 += "WHERE CA_ESTATUS = 'P'";
                    int rows1 = ctx.Database.ExecuteSqlRaw(sql1);

                    string sql2 = "UPDATE PS_CA_ROL_DESCUEN_TC SET CA_ESTATUS = 'C' ";
                    sql2 += "WHERE CA_ESTATUS = 'P'";
                    int rows2 = ctx.Database.ExecuteSqlRaw(sql2);

                    
                ctx.Database.CommitTransaction();

                ViewBag.Mensaje = "Productos procesados con éxito!";
                return View("Index");
                }
            }
            catch (System.Exception ex)
            {
                if(ctx.Database.CurrentTransaction != null)ctx.Database.RollbackTransaction();
                Errores.Add("Error en las credenciales de conexión IBS!");
                Errores.Add(ex.Message);
                ViewBag.Errores = Errores;
                return View("LoginPI");
                
            }
            

            ViewBag.Mensaje = "Productos procesados con éxito!";
            return View("Index");
        }

        public IActionResult LoginCheques(string usuario, string clave){

            
            return View("LoginCheques");
        }

        public IActionResult ChequesIBS(string usuario, string clave){

            List<string> Errores = new List<string>();
            
            string DSN = config.GetValue<string>("ODBC:DSN");
            string conStr= "DSN=" + DSN + "; UID=" + usuario.Trim() +"; PWD=" + clave.Trim() + ";";
             
            
            OdbcConnection con = new OdbcConnection(conStr);
            
            try
            {
                if(con != null || con.State == System.Data.ConnectionState.Closed){
                con.Open();
                con.Close();
                ctx.Database.BeginTransaction();
                    
                    string sql = "UPDATE PS_CA_ROL_PAGO_ACREEDOR SET USUARIO = {0} ";
                    sql += "WHERE STATUS = 'I' ";
                    int rows = ctx.Database.ExecuteSqlRaw(sql, usuario);

                    string[] _user = HttpContext.User.Identity.Name.ToString().Split(@"\");
                    string strSql = "Exec USP_CA_ROL_PAGO_ACREEDOR {0}, {1}";
                    ctx.Database.ExecuteSqlRaw(strSql, 1, _user[1]);
                    
                ctx.Database.CommitTransaction();

                ViewBag.Mensaje = "Cheques procesados con éxito!";
                return View("Index");
                }
            }
            catch (System.Exception ex)
            {
                if(ctx.Database.CurrentTransaction != null)ctx.Database.RollbackTransaction();
                Errores.Add("Error en las credenciales de conexión IBS!");
                Errores.Add(ex.Message);
                ViewBag.Errores = Errores;
                return View("LoginCheques");
                
            }
            

            ViewBag.Mensaje = "Productos procesados con éxito!";
            return View("Index");
        }

        public IActionResult LoginBenef(string usuario, string clave){

            return View("LoginBenef");
        }

        public IActionResult AcredBenef(string usuario, string clave){

            List<string> Errores = new List<string>();
            
            string DSN = config.GetValue<string>("ODBC:DSN");
            string conStr= "DSN=" + DSN + "; UID=" + usuario.Trim() +"; PWD=" + clave.Trim() + ";";
             
            
            OdbcConnection con = new OdbcConnection(conStr);
            
            try
            {
                if(con != null || con.State == System.Data.ConnectionState.Closed){
                con.Open();
                con.Close();
                ctx.Database.BeginTransaction();
                    
                    string sql = "UPDATE PS_CA_ROL_ACRED_EMPL SET CA_USUARIO = {0} ";
                    sql += "WHERE CA_ESTATUS = 'P' ";
                    int rows = ctx.Database.ExecuteSqlRaw(sql, usuario);

                    string[] _user = HttpContext.User.Identity.Name.ToString().Split(@"\");
                    string strSql = "Exec USP_CA_ACRED_BENEFICIO {0}, {1}";
                    ctx.Database.ExecuteSqlRaw(strSql, 1, _user[1]);

                    string sql1 = "UPDATE PS_CA_ROL_ACRED_EMPL SET CA_ESTATUS = 'A' ";
                    sql1 += "WHERE CA_ESTATUS = 'P' ";
                    int rows1 = ctx.Database.ExecuteSqlRaw(sql1);
                    
                ctx.Database.CommitTransaction();

                ViewBag.Mensaje = "Beneficios procesados con éxito!";
                return View("Index");
                }
            }
            catch (System.Exception ex)
            {
                if(ctx.Database.CurrentTransaction != null)ctx.Database.RollbackTransaction();
                Errores.Add("Error en las credenciales de conexión IBS!");
                Errores.Add(ex.Message);
                ViewBag.Errores = Errores;
                return View("LoginBenef");
                
            }
            

            ViewBag.Mensaje = "Productos procesados con éxito!";
            return View("Index");
        }


    }
}
