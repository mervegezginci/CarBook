using CarBook.Dto.FooterAddressDtos;
using CarBook.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "İletişim";
            ViewBag.v2 = "Bizimle İletişime Geçin";

            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync(
                "https://localhost:7046/api/FooterAddresses"
            );

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();

                var values =
                    JsonConvert.DeserializeObject<List<ResultFooterAddressDto>>(jsonData);

                return View(values.FirstOrDefault());
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            var client = _httpClientFactory.CreateClient();

            createContactDto.SendDate = DateTime.Now;

            var jsonData = JsonConvert.SerializeObject(createContactDto);

            StringContent stringContent = new StringContent(
                jsonData,
                Encoding.UTF8,
                "application/json"
            );

            var responseMessage = await client.PostAsync(
                "https://localhost:7046/api/Contacts",
                stringContent
            );

            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi.";

                return RedirectToAction("Index");
            }

            TempData["ErrorMessage"] = "Mesaj gönderilirken bir hata oluştu.";

            return RedirectToAction("Index");
        }
    }
}