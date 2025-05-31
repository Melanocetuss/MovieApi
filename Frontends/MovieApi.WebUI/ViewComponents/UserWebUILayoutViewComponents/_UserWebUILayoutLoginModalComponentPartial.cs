using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserWebUILayoutViewComponents
{
    public class _UserWebUILayoutLoginModalComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
