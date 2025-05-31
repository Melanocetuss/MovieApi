using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult MovieList()
        {
            ViewBag.Title = "Film Listesi";
            ViewBag.Page = "Ana Sayfa";
            ViewBag.Description = "Tüm Filmler";
            return View();
        }
    }
}
