using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCloudTagByBlogComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.blogid = id;
            return View();
        }
    }
}