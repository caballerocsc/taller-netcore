using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taller_netcore.Models;

namespace taller_netcore.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
       // [ErroresFilter]
        public IActionResult Login(login model)
        {
            Console.WriteLine ("ay");
            if (ModelState.IsValid)
            {
                if (model.usuario.Equals("cess") && model.clave.Equals("123"))
                {
                    HttpContext.Session.SetString("Autenticado", "True");
                    HttpContext.Session.SetString("Usuario", model.usuario);
                    //return RedirectToAction("UserSpace");
                    Console.WriteLine ("Entro");
                    return RedirectToAction("Bienvenido");
                }
                
            }
            return View(model);
        }

        public IActionResult Bienvenido()
		{
			return View();
		}

        
    }
}