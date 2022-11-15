using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Data.EntityFramework.Repository.Concrete;
using TraversalCore.Entity.Concrete;
using TraversalCore.Services.Abstract;
using TraversalCore.Services.Concrete;

namespace TraversalCore.Mvc.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {

            ViewBag.i = id;
            var values = _destinationService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }

    }
}
