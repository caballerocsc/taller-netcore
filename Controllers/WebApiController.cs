using Microsoft.AspNetCore.Mvc;
using taller_netcore.Models;
using System;

namespace taller_netcore.Controllers
{
    [Route("api/WebApi")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        [HttpPost]
        public IActionResult  Contactenos(FormContactoWebApi model)
        {
             Console.WriteLine("****************entre");
            if (ModelState.IsValid)
			{
				return Ok(model);
			}
			else
			{
				return BadRequest();
			}
        }

        [HttpGet]
        public String get(){
            return "hola mundo";
        }
    }
}