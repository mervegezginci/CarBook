using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture_CarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _ServiceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
