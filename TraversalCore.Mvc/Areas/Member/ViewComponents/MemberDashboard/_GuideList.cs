using Microsoft.AspNetCore.Mvc;
using TraversalCore.Data.EntityFramework.Repository.Concrete;
using TraversalCore.Services.Abstract;
using TraversalCore.Services.Concrete;

namespace TraversalCore.Mvc.Areas.Member.ViewComponents.MemberDashboard
{
    public class _GuideList: ViewComponent
    {

        GuideManager guideManager = new GuideManager(new EfGuideRepository());

        public IViewComponentResult Invoke()
        {
            var guideList = guideManager.TGetList();
            return View(guideList);  
        }
    }
}
