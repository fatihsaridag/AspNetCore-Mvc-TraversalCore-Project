using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCore.Entity.Concrete
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string PersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string ReservationStatus { get; set; }
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
