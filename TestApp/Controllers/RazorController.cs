using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers {
	public class RazorController : Controller {
		public IActionResult Index() {
			return View();
		}
	}
}
