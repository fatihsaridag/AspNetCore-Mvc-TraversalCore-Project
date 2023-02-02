using Microsoft.AspNetCore.Mvc;
using TraversalCore.Services.Abstract;

namespace TraversalCore.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService= contactUsService;
        }

        public IActionResult Index()
        {
            var contactUsList = _contactUsService.GetListContactUsByTrue();
            return View(contactUsList);
        }
    }
}
