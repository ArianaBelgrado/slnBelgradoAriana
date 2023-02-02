using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using slnBelgradoAriana.Data;
using slnBelgradoAriana.Models;

namespace slnBelgradoAriana.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DbRecetasMVC context;
        public RecetaController(DbRecetasMVC context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var receta = context.Recetas.ToList();
            return View(receta);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Receta receta = new Receta();
            return View("Create", receta);
        }

        [HttpGet]
        public IActionResult IndexByAutor(string autor)
        {
            var recetas = (from e in context.Recetas
                           where e.Autor == autor
                           select e).ToList();
            return View("Index", recetas);
        }

        [HttpGet]
        public IActionResult IndexByApellido(string apellido)
        {
            var recetas = (from e in context.Recetas
                           where e.Apellido == apellido
                           select e).ToList();
            return View("Index", recetas);
        }


        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index", receta);
            }
            return View(receta);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta receta = TraerUna(id);
            if (receta == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }
        }
        private Receta TraerUna(int id)
        {
            return context.Recetas.Find(id);
        }
    }
}
