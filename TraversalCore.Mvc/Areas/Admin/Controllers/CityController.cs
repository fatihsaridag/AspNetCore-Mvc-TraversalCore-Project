using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCore.Entity.Concrete;
using TraversalCore.Mvc.Models;
using TraversalCore.Services.Abstract;

namespace TraversalCore.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }


        public IActionResult Index()    //Index işlemlerin çağrıldıgı yer olacak.
        {
            return View();
        }

        public IActionResult CityList()     //Böylece index üzerinde listele butonuna tıkladıgımız anda sayfa refresh olmadan citylist karşılıyor olaak.
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.TGetById(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }

        public IActionResult UpdateCity(Destination destination)
        {
            _destinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }

    }
}
