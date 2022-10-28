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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;

        public FeatureManager(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public void TAdd(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureRepository.GetList();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
