using Microsoft.AspNetCore.Mvc;
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
            return View();
        }
    }
}
