using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    //[Route("IndexBased")]

    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conventional()
        {
            return Ok("Testando nova ação do controlador Appointment com Conventional Routing ");
        }

        [Route("IndexBased/{*Main}")]
        public IActionResult IndexBasedMain()
        {
            return Ok("Testando nova ação IndexBasedMain do controlador Appointment com IndexBased Routing");
        }

        [Route("IndexBased/Aux")]
        public IActionResult IndexBasedAux()
        {
            return Ok("Testando nova ação IndexBasedAux do controlador Appointment com IndexBased Routing");
        }

        public IActionResult GetSomeData([FromQuery]string values)
        {
            return Ok($"The value: {values} is from Query string");
        }
    }
}
