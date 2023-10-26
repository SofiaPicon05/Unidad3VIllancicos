using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using Villancicos.Models;
using VIllancicos.Models;
using VIllancicos.Repositories;

namespace VIllancicos.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class VillancicosController : Controller
	{
		private readonly VillancicoRepository Repository;
		public VillancicosController(VillancicoRepository repos)  //inyeccion 
		{
			Repository = repos;
		}



		[HttpGet]
		public IActionResult Agregar()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Agregar(Villancico v)
		{
			if (string.IsNullOrWhiteSpace(v.Nombre))
			{
				ModelState.AddModelError("", "Escriba el nombre del villancico");
			}
			if (string.IsNullOrWhiteSpace(v.Nombre))
			{
				ModelState.AddModelError("", "Escriba el nombre del compositor de villancico");
			}
			if (string.IsNullOrWhiteSpace(v.Nombre))
			{
				ModelState.AddModelError("", "Escriba la letra del villancico");
			}
			if (string.IsNullOrWhiteSpace(v.Nombre))
			{
				ModelState.AddModelError("", "Escriba la direccion del villancico en Youtube");
			}
			if (ModelState.IsValid)
			{
				Repository.Insert(v);
				return RedirectToAction("Index", "Home", new { area = "Admin" });
			}
			else
			return View(v);
		}
	}
}
