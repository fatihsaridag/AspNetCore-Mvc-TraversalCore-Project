using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Contexts;
using TraversalCore.Data.EntityFramework.Repository.Abstract;
using TraversalCore.Data.Repository;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Data.EntityFramework.Repository.Concrete
{
    public class EfReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.ReservationStatus == "Onaylandı" && x.AppUserId == id).ToList();
            };
        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.ReservationStatus == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();
            };
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.ReservationStatus == "Onay Bekliyor" && x.AppUserId == id).ToList();
            };

        }
    }
}
