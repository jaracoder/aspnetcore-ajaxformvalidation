using ASP.NET.Core.AjaxFormValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ASP.NET.Core.AjaxFormValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [AcceptVerbs("POST")]
        public ActionResult Register(Alumno a)
        {
            if (!ModelState.IsValid)
            {
                return Json("El modelo de no es válido");
            }

            return Json(true);
        }
    }
}
