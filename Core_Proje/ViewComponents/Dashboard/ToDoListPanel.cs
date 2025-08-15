using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        private readonly IToDoListService _toDoListService;

        public ToDoListPanel(IToDoListService toDoListService)
        {
            _toDoListService = toDoListService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _toDoListService.TGetList().OrderByDescending(x => x.ToDoListID).Take(5).ToList();
            return View(values);
        }
    }
}
