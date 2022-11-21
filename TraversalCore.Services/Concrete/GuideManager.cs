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
            _guideRepository.Insert(entity);
        }

        public void TChangeToFalseByGuide(int id)
        {

            _guideRepository.ChangeToFalseByGuide(id);
        }

        public void TChangeToTrueByGuide(int id)
        {
            _guideRepository.ChangeToTrueByGuide(id);

        }

        public void TDelete(Guide entity)
        {
            _guideRepository.Delete(entity);
        }

        public Guide TGetById(int id)
        {
            return _guideRepository.GetById(id);
        }

        public List<Guide> TGetList()
        {
            return _guideRepository.GetList();
        }

        public void TUpdate(Guide entity)
        {
            _guideRepository.Update(entity);
        }
    }
}
