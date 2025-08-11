using Microsoft.AspNetCore.Mvc;

namespace Agriculture.ViewComponents
{
    public class _DashboardScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
