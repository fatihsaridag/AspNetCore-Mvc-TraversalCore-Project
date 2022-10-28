using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Concrete;
using TraversalCore.Services.Concrete;

namespace TraversalCore.Mvc.ViewComponents.Default
{
    public class Feature : ViewComponent
    {
        //Feature tablomuzdan veri çekmemiz gerekiyor.
        FeatureManager featureManager = new FeatureManager(new EfFeatureRepository());
     
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList();
           // ViewBag.image1 = featureManager.get
            return View(values);
        }
    }
}
