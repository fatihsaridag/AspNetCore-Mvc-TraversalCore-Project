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
    public class GuideManager : IGuideService
    {
        private readonly IGuideRepository _guideRepository;

        public GuideManager(IGuideRepository guideRepository)
        {
            _guideRepository = guideRepository;
        }

        public void TAdd(Guide entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            return _guideRepository.GetList();
        }

        public void TUpdate(Guide entity)
        {
            throw new NotImplementedException();
        }
    }
}
