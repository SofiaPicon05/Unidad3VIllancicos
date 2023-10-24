using Microsoft.AspNetCore.Mvc;
using VIllancicos.Models.ViewModels;
using VIllancicos.Repositories;

namespace VIllancicos.Controllers
{
    public class HomeController : Controller
    {
        private readonly VillancicoRepository repository;

        //Utilizando Inyeccion de dependencias
        public HomeController(VillancicoRepository repository)
        {
            this.repository = repository;
        }
        //
        public IActionResult Index()
        {
            var data=repository.Get().Select(x => x.Nombre);
            return View(data);
        }
        public IActionResult Villancico(string? Id)
        {
            Id = Id?.Replace("-", " ");

            var data = repository.Get(Id??"");
           if(data != null)
           {
                VillancicoViewModel vm = new()
                {
                    Año = data.Anyo ?? 0,
                    Compositor = data.Compositor,
                    Letra = data.Letra,
                    Nombre = data.Nombre,
                    URL = data.VideoUrl
                };
                return View(vm);
           }
            return RedirectToAction("Index");    
        }
    }
}
