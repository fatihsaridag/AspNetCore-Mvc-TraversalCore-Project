using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCore.Mvc.CQRS.Commands.GuideCommands;
using TraversalCore.Mvc.CQRS.Queries.GuideQueries;

namespace TraversalCore.Mvc.Areas.Admin.Controllers
{

    [Area("Admin")]
    [AllowAnonymous]
    public class GuideMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }


        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }


        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var values = await _mediator.Send(new GetGuideByIdQuery(id));
            return View(values);

        }

        [HttpGet]
        public IActionResult AddGuides()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> AddGuides(CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }


    }
}
