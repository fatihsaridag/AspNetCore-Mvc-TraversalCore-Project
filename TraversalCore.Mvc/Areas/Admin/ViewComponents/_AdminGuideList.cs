using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Mvc.Areas.Admin.ViewComponents
{
    public class _AdminGuideList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
