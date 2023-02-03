using AutoMapper;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TraversalCore.DTOs.AnnouncementDTOs;
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
        private readonly IMapper _mapper;


        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());
            return View(values);

            //List<Announcement> announcementListEntity = _announcementService.TGetList();
            //List<AnnouncementListViewModel> model = new List<AnnouncementListViewModel>();
            //AnnouncementListViewModel announcementListViewModel = new AnnouncementListViewModel();
            //foreach (var item in announcementListEntity)
            //{
            //    announcementListViewModel.AnnouncementId=  item.AnnouncementId;
            //    announcementListViewModel.Title=  item.Title;
            //    announcementListViewModel.Content =  item.Content;

            //    model.Add(announcementListViewModel);
            //}
            //return View(model);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto announcementAddDto)
        {
            if (ModelState.IsValid)
            {
                var announcementEntity = _mapper.Map<Announcement>(announcementAddDto);
                _announcementService.TAdd(announcementEntity);
                return RedirectToAction("Index");
            }
            return View(announcementAddDto);
        }


        public IActionResult DeleteAnnouncement(int id)
        {
           var announcementEntity =  _announcementService.TGetById(id);
            if (announcementEntity != null)
            {
                _announcementService.TDelete(announcementEntity);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var annnouncementEntity = _announcementService.TGetById(id);
            var announcementDto = _mapper.Map<AnnouncementUpdateDto>(annnouncementEntity);
            return View(announcementDto);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(AnnouncementUpdateDto announcementUpdateDto)
        {
            if (ModelState.IsValid)
            {
                Announcement announcement = new Announcement();
                announcement.AnnouncementId = announcementUpdateDto.AnnouncementId;
                announcement.Title = announcementUpdateDto.Title;
                announcement.Content = announcementUpdateDto.Content;
                announcement.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                _announcementService.TUpdate(announcement);
                return RedirectToAction("Index");
            }
            return View(announcementUpdateDto);
        }
    }
}
