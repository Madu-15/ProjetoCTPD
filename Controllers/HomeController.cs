using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Projeto_CTPD_Maria_Eduarda.Models;

namespace Projeto_CTPD_Maria_Eduarda.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Parceiros()
        {
            return View();
        }
        public IActionResult QuemSomos()
        {
            return View();
        }
       
        public IActionResult Serviços()
        {
            return View();
        }

        public IActionResult FaleConosco(){
                      
            return View();
        } 

        [HttpPost]
        public IActionResult FaleConosco(FaleConosco fc){
    
            FaleConoscoRepository fcr = new FaleConoscoRepository();
            fcr.Cadastrar(fc);
            
            return RedirectToAction("FaleConosco");
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
