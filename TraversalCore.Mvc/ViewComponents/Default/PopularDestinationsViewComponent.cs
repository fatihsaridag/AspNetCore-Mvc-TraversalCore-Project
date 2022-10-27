using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Concrete;
using TraversalCore.Services.Concrete;

namespace TraversalCore.Mvc.ViewComponents.Default
{
    [ViewComponent(Name = "PopularDestinationsViewComponent")] //Solution
    public class PopularDestinationsViewComponent : ViewComponent
    {

        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
