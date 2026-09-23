using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "İletişim";
            ViewBag.v2 = "Bizimle İletişime Geçin";
            return View();
        }
    }
}
