using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Entity.Concrete;
using TraversalCore.Services.Abstract;

namespace TraversalCore.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly IReservationService _reservationService;

       


        public UserController(UserManager<AppUser> usermanager, IReservationService reservationService)
        {
            _usermanager = usermanager;
            _reservationService = reservationService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _usermanager.Users.ToListAsync();
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user =  await _usermanager.FindByIdAsync(id.ToString());
            if (user != null)
            {
               await _usermanager.DeleteAsync(user);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(int id)
        {
            var user = await _usermanager.FindByIdAsync(id.ToString());
            if (user != null)
            {
                await _usermanager.UpdateAsync(user);
                return RedirectToAction("Index");
            }

            return View();

        }

        public async Task<IActionResult> CommentUser(int id)
        {
            var user = await _usermanager.FindByIdAsync(id.ToString());
            if (user != null)
            {
                     return View();
            }
            return View();
        }

        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }

    }
}
