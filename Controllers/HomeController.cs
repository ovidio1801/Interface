using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RRHH.Models;

namespace RRHH.Controllers
{

    [Authorize(Policy = "CubitosUsers")]
    [Authorize(Policy = "CubitosAdmin")]
    public class HomeController : Controller
    {

        private IConfiguration config;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IConfiguration _config)
        {
            _logger = logger;
            config = _config;
        }

        public IActionResult Index()
        {


            string user = HttpContext.User.Identity.Name.ToString();

            
            return View();
        }

        public IActionResult Close(){

            return new ContentResult {
            ContentType = "text/html",
            StatusCode = (int) HttpStatusCode.OK,
            Content = "<script type=\"text/javascript\">window.close();</script>"};

        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Reportes(){
            string reportServer = config.GetValue<string>("ReportServer");
            return Redirect(reportServer);
        }
    }
}
