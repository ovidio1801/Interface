using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RRHH.Data;
using RRHH.Models;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using RRHH.Services;


namespace RRHH.Controllers
{
    public class ChequesController : Controller
    {

        private readonly RRHHContext ctx;
        private readonly IConfiguration _configuration;

        public ChequesController(RRHHContext context, IConfiguration Configuration)
        {
            ctx = context;
            _configuration = Configuration;
        }
        public IActionResult Index()
        {

            string conString = _configuration.GetConnectionString("RRHHContext");
            var _user = HttpContext.User.Identity.Name;

            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                using(SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandType = System.Data.CommandType.StoredProcedure;
                    com.CommandText = "USP_CA_ROL_PAGO_ACREEDOR";
                    com.Parameters.Add("@opcion", System.Data.SqlDbType.Int);
                    com.Parameters["@opcion"].Value = 0;
                    com.Parameters.Add("@usuario", System.Data.SqlDbType.VarChar,20);
                    com.Parameters["@usuario"].Value = _user;
                    int _rows = com.ExecuteNonQuery();

                }
                con.Close();
            }

            List<TipoCheque> tcheque = ctx.TiposCheque.ToList();
            //ViewBag.TipoCheque = new SelectList(tcheque, "COD_TIPO_CHEQUE", "DESCRIPCION");
            ViewBag.tiposCheque = tcheque;
            return View();
        }

        [HttpPost]
        public IActionResult Index(List<Cheque> model, string desde, string hasta, string tipoCheque, string secIni, string cargar, string imprimir)
        {
           

            if (string.IsNullOrEmpty(tipoCheque))
            {
                tipoCheque = "AC";
            }

            List<TipoCheque> tcheque = ctx.TiposCheque.ToList();

            //if(model.Count() == 0)
            //{
                List<Cheque> _cheques = ctx.Cheques.Where(c => c.status == "P" && c.tipo_acreedor == tipoCheque && c.forma_pago == "CHE").OrderBy(c => c.nombre).ToList();
                model = _cheques;
            //}
           
            

            ViewBag.tiposCheque = tcheque;
            ViewBag.Desde = desde;
            ViewBag.Hasta = hasta;
            ViewBag.TipoCheque = tipoCheque;
            ViewBag.SecIni = secIni;
            return View(model);
                       
        }


        public IActionResult Imprimir(List<Cheque> model, string desde, string hasta, string tipoCheque, string secIni, string cargar, string imprimir)
        {
            List<string> errores = new List<string>();
            if (string.IsNullOrEmpty(secIni))
            {
                errores.Add("Secuencia Inicial no puede esta vacío");
            }

            List<TipoCheque> tcheque = ctx.TiposCheque.ToList();

            if (errores.Count != 0 && imprimir == "Imprimir...")
            {
                ViewBag.Errores = errores;
                ViewBag.tiposCheque = tcheque;
                ViewBag.Desde = desde;
                ViewBag.Hasta = hasta;
                ViewBag.TipoCheque = tipoCheque;
                ViewBag.SecIni = secIni;
                return View("Index",model);
            }

            List<Cheque> chequesImp = model.Where(x => x.imp == true).ToList();
            int sec = int.Parse(secIni);
            string[] _user =  HttpContext.User.Identity.Name.ToString().Split(@"\");
            var fecha = DateTime.Now;
            

            for (int i = 0; i < chequesImp.Count(); i++)
            {
                int numCheque = sec + i;

                //Ovidio: actualización estandard en caso de que hubiera primary key, al final se usó
                //para la pantalla de cheques impresos
                chequesImp[i].cheque = numCheque.ToString();
                chequesImp[i].usuario = _user[1];
                chequesImp[i].fecha_impresion = fecha;
                chequesImp[i].status = "I";
                ctx.Cheques.Update(chequesImp[i]);
                //ctx.SaveChanges(); se comentó por que la tabla no tiene pk, y enviava errores raros

                string strSql = "Update PS_CA_ROL_PAGO_ACREEDOR set cheque = {0}, usuario = {1}, " +
                    "fecha_impresion = {2}, [status] = {3} Where empresa = {4} and oficina = {5} " +
                    "and codigo = {6} and fecha_registro = {7} and monto = {8}";

                //Ovidio 2021 - 06 - 22: recordar descomentr para la implementación
                //int rows = ctx.Database.ExecuteSqlRaw(strSql, numCheque.ToString(), _user[1], fecha, "I",
                //    chequesImp[i].empresa, chequesImp[i].oficina, chequesImp[i].codigo,
                //    chequesImp[i].fecha_registro, chequesImp[i].monto);

                string coment = "";
                switch (chequesImp[i].tipo_acreedor)
                {
                    case "AC": 
                        coment = "Ver Listado Adjunto";
                        break;
                    case "AS":
                        coment = "Asistencia Económica";
                        break;
                    case "EM":
                        coment = "Pago de Nómina";
                        break;
                    default:
                        coment = "Ver Listado Adjunto";
                        break;
                }

                TextFile.WriteFile(fecha, chequesImp[i].nombre, chequesImp[i].monto, coment);
                ExecCmd.ExecuteCommand("cheque.bat");
        
                //Debug.WriteLine("Se imprimió el cheque " + numCheque.ToString() + " a nombre de " + chequesImp[i].nombre + " fecha impresion " + chequesImp[i].fecha_impresion);

            }

            //model = null;
            ViewBag.Mensaje = "Los Cheques se imprimieron con éxito!";
            ViewBag.tiposCheque = tcheque;
            ViewBag.Desde = null;
            ViewBag.Hasta = null;
            ViewBag.TipoCheque = "";
            ViewBag.SecIni = null;
            return View("ChequesImpresos", chequesImp);


        }

    }
}
