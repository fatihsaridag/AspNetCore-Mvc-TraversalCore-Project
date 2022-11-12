using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Mvc.Areas.Member.ViewComponents.MemberDashboard
{
    public class _PlatformSetting : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
