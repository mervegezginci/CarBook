using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.CommentViewComponents
{
    public class _AddCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.blogid = id;
            return View();
        }
    }
}