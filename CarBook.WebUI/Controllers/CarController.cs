using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Arabalar";
            ViewBag.v2 = "Arabanızı Seçiniz";
            return View();
        }
    }
}
