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
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutRepository _subAboutRepository;

        public SubAboutManager(ISubAboutRepository subAboutRepository)
        {
            _subAboutRepository = subAboutRepository;
        }

        public void TAdd(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutRepository.GetList();
        }

        public void TUpdate(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
