using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TraversalCore.Entity.Concrete;
using TraversalCore.Mvc.Models;
using TraversalCore.Services.Abstract;

namespace TraversalCore.Mvc.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            List<Announcement> announcementListEntity = _announcementService.TGetList();
            List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
            foreach (var item in announcementListEntity)
            {
                announcementListViewModel.AnnouncementId=  item.AnnouncementId;
                announcementListViewModel.Title=  item.Title;
                announcementListViewModel.Content =  item.Content;

                model.Add(announcementListViewModel);
            }
            return View(model);
        }
    }
}
