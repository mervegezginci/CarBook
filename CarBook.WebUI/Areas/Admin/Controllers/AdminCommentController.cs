using CarBook.Dto.CommentDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    [Route("Admin/AdminComment")]
    public class AdminCommentController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCommentController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Comments");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);
                return View(values ?? new List<ResultCommentDto>());
            }

            return View(new List<ResultCommentDto>());
        }

        [Route("CommentListByBlog/{id}")]
        public async Task<IActionResult> CommentListByBlog(int id)
        {
            ViewBag.v = id;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Comments/CommentListByBlog?id=" + id);

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData);
                return View("Index", values ?? new List<ResultCommentDto>());
            }

            return View("Index", new List<ResultCommentDto>());
        }
    }
}