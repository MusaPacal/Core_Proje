using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class UserMessageList: ViewComponent
    {
        private readonly IUserMessageService _userMessageService;

        public UserMessageList(IUserMessageService userMessageService)
        {
            _userMessageService = userMessageService;
        }
        public IViewComponentResult Invoke()
        {
            var value = _userMessageService.GetListUserMessageWithUserService().OrderByDescending(x => x.Date).Take(5).ToList();
            return View(value);
        }
    }
}
