using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class VisitorsList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
