using Microsoft.AspNetCore.Mvc;
using personas.Models;
using System.Collections.Generic;

namespace personas.Controllers
{
    public class ImcController : Controller
    {
        public static List <PersonaModel> personas = new List <PersonaModel> ();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonaModel model)
        {
            if (ModelState.IsValid)
            {
                personas.Add(model);
                return RedirectToAction("Lista");
            }
            
            return View(model);
        }
        public IActionResult lista()
        {
            return View(personas);
        }
    }
}
