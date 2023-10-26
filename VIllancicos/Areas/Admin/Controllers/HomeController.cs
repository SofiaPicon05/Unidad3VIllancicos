using Microsoft.AspNetCore.Mvc;
using VIllancicos.Areas.Admin.Models;
using VIllancicos.Repositories;

namespace VIllancicos.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
		private readonly VillancicoRepository repository;
		public HomeController(VillancicoRepository repository)
        {
			this.repository = repository;  // crear una dependencia , le diras al constructor q te de un repositorio para poder crearlo, se inyecta.
		}
		[Area("Admin")]
		public IActionResult Index()
        {
            var data = repository.Get().Select(x => new AdminIndexViewModel
            {
                Id = x.Id,
                Nombre = x.Nombre
            }); 

            return View(data);
        }
    }
}
