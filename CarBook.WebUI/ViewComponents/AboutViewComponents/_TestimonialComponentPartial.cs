using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}