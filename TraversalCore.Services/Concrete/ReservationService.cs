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
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public List<Reservation> GetListWithReservationByAccepted(int Id)
        {
            return _reservationRepository.GetListWithReservationByAccepted(Id);
        }

        public List<Reservation> GetListWithReservationByPrevious(int Id)
        {
            return _reservationRepository.GetListWithReservationByPrevious(Id);
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int Id)
        {
            return _reservationRepository.GetListWithReservationByWaitApproval(Id);
        }

        public void TAdd(Reservation entity)
        {
            _reservationRepository.Insert(entity);
        }

        public void TDelete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
