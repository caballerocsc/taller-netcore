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
                //este bloque solo tiene como funcion disparar una excepcion con propositos académicos 
                if(model.Nombres.Equals("cess")){
                    try{
                        var explote = int.Parse(model.Nombres);
                    }
                    catch(Exception e){
                        Console.WriteLine (e);
                        return RedirectToAction("Error");
                    }
                }
                return RedirectToAction("Gracias");
            }
            return View();
        }

        public IActionResult Gracias()
		{
			return View();
		}

        public IActionResult Error()
		{
			return View();
		}

    }
}
