using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Experience
{
    public class ExperienceList: ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public ExperienceList(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _experienceService.TGetList();
            return View(values);
        }
    }
}
