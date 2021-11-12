using Microsoft.AspNetCore.Mvc;
using Pacientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacientes.Controllers
{
    public class EspecialidadController : Controller
    {
        private readonly TurnosContext _context;

        public EspecialidadController(TurnosContext context)
        {

            _context = context;

        }


        public IActionResult Index()
        {
            return View(_context.especialidad.ToList());
        }
    }
}
