using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Concrete;
using TraversalCore.Services.Concrete;

namespace TraversalCore.Mvc.ViewComponents.Default
{
    public class Testimonial : ViewComponent
    {
        //Buraya Testimonial manageri getirmemiz gerekiyor.

        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialRepository());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}
