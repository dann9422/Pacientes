using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacientes.Controllers
{
    public class EspecialidadController : Controller
    {
        public EspecialidadController()
        {


        }

        
        public IActionResult Index()
        {
            return View();
        }
    }
}
