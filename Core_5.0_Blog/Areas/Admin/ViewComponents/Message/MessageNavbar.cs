using Microsoft.AspNetCore.Mvc;

namespace Core_5._0_Blog.Areas.Admin.ViewComponents.Message
{
    public class MessageNavbar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
