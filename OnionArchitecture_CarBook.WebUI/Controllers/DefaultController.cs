using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture_CarBook.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
