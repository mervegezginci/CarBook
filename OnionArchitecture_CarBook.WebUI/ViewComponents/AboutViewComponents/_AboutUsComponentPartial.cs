using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture_CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}