using Microsoft.AspNetCore.Mvc;
using taller_netcore.Models;
using System;
using Microsoft.AspNetCore.Http;

namespace taller_netcore.Controllers
{
    public class FormContactoController : Controller
    {
        [HttpGet]
        public IActionResult FormContacto()
        {
            return View();
        }



        [HttpPost]
        public IActionResult FormContacto(FormContacto model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Gracias");
            }
            return View(model);
        }

        public IActionResult Gracias()
		{
			return View();
		}

    }
}
