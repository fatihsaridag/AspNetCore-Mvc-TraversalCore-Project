using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Concrete;
using TraversalCore.Entity.Concrete;
using TraversalCore.Services.Concrete;

namespace TraversalCore.Mvc.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());
        ReservationService reservationService = new ReservationService(new EfReservationRepository());


        public IActionResult MyCurrentReservation()
        {
            return View();
        }


        public IActionResult MyOldReservation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList() select new SelectListItem
            {
                Text = x.City,
                Value =x.DestinationId.ToString()
            }).ToList();


            ViewBag.v = values;

            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserId = 2;
            reservationService.TAdd(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
