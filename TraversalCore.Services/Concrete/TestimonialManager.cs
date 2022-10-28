using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Abstract;
using TraversalCore.Entity.Concrete;
using TraversalCore.Services.Abstract;

namespace TraversalCore.Services.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialManager(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        public void TAdd(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial entity)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialRepository.GetList();
        }

        public void TUpdate(Testimonial entity)
        {
            throw new NotImplementedException();
        }
    }
}
