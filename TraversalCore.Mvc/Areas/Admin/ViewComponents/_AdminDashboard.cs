using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalCore.Data.EntityFramework.Contexts;

namespace TraversalCore.Mvc.Areas.Admin.ViewComponents
{
    public class _AdminDashboard : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
     
            return View();
        }
    }
}
