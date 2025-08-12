using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class LastProject: ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public LastProject(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            var lastFiveProjects =_portfolioService.TGetList().OrderByDescending(x => x.PortfolioID).Take(5).ToList();
            return View(lastFiveProjects);
        }
    }
}
