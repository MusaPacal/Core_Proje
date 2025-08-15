using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class PortfolioSlide: ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioSlide(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }
        public IViewComponentResult Invoke()
        {
            // Listeyi bir kez alıyoruz
            var portfolioList = _portfolioService.TGetList()
                                .OrderByDescending(x => x.PortfolioDate)
                                .ToList();

            // Null kontrolü
            var firstItem = portfolioList.FirstOrDefault();
            ViewBag.g1 = firstItem != null ? firstItem.PortfolioImgUrl : "";

            // En son eklenen tek portfolioyu al
            var values = portfolioList.Take(1).ToList();

            return View(values);
        }
    }
}
