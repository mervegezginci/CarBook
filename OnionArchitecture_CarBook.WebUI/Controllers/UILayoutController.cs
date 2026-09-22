using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture_CarBook.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
