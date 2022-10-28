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
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationRepository _destinationRepository;

        public DestinationManager(IDestinationRepository destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public void TAdd(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public Destination TGetById(int id)
        {
            return _destinationRepository.GetById(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationRepository.GetList();
        }

        public void TUpdate(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
