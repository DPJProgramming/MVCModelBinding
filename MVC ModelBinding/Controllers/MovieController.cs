using Microsoft.AspNetCore.Mvc;
using MVC_ModelBinding.Models;

namespace MVC_ModelBinding.Controllers {
	public class MovieController : Controller {

		
		public IActionResult Index() {
			return View();
		}

		[HttpGet]
		public IActionResult Create() {
			return View();
		}

		[HttpPost]
		public IActionResult Create(Movie movieData) {
			if(ModelState.IsValid) {

				//add to database
				return RedirectToAction("Index", "Home");
			}
			return View();
		}
	}
}
