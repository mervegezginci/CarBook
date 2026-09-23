using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Ödemeler";
            ViewBag.v2 = "Ödeme Türleri";
            return View();
        }
    }
}
