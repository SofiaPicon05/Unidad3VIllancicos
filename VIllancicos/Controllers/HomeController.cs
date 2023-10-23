using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Villancico()
        {
            return View();
        }
    }
}
