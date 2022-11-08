using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalCore.Entity.Concrete;

namespace TraversalCore.Services.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int Id);
        List<Reservation> GetListWithReservationByAccepted(int Id);
        List<Reservation> GetListWithReservationByPrevious(int Id);
    }
}
