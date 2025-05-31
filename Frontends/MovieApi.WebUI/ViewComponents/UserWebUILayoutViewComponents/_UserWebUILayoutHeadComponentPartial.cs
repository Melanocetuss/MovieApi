using Microsoft.AspNetCore.Mvc;

namespace MovieApi.WebUI.ViewComponents.UserWebUILayoutViewComponents
{
    public class _UserWebUILayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}