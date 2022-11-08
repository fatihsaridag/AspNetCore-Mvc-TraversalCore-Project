using Microsoft.AspNetCore.Identity;
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


        private readonly UserManager<AppUser> _userManager;


        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult MyCurrentReservation()
        {
            return View();
        }


        public IActionResult MyOldReservation()
        {
            return View();
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationService.GetListApprovalReservation(values.Id);
            ViewBag.v = values.Id;
            return View(valuesList);
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
            reservation.AppUserId = 6;
            reservation.ReservationStatus = "Onay Bekliyor";
            reservationService.TAdd(reservation);
            return RedirectToAction("MyCurrentReservation");
        }
    }
}
