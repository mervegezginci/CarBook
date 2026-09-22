using Microsoft.AspNetCore.Mvc;

namespace OnionArchitecture_CarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultLast5CarsWithBrandsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
