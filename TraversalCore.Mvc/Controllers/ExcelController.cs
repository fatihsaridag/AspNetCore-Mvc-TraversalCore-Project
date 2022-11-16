using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TraversalCore.Data.EntityFramework.Contexts;
using TraversalCore.Mvc.Models;

namespace TraversalCore.Mvc.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();

            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            ExcelPackage excel = new ExcelPackage();                    
            var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");        //Öncelikle çalışma sayfası oluşturuyoruz.
            workSheet.Cells[1, 1].Value = "Rota";                           // Bu çalışma sayfasının içerisine 1. satır 1. sütuna Rota de 
            workSheet.Cells[1, 2].Value = "Rehber";                         // 1. satır 2. sütuna 
            workSheet.Cells[1, 3].Value = "Kontenjan";

            workSheet.Cells[2, 1].Value = "Gürcistan Batum Turu";
            workSheet.Cells[2, 2].Value = "Kadir Yıldız";
            workSheet.Cells[2, 3].Value = "50";

            workSheet.Cells[3, 1].Value = "Sırbistan Makedonya Turu";
            workSheet.Cells[3, 2].Value = "Zeynep Öztürk";
            workSheet.Cells[3, 2].Value = "35";

            var bytes = excel.GetAsByteArray();                            //Exceli byte formatına dönüştürdük 
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "dosya2.xlsx");     //Geriye Dosya değerinde bir byte ve 

        }


        public IActionResult DestinationExcelReport()
        {
            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Tur Listesi");         //Tur Listesi Adlı bir sayfa oluşturduk
                workSheet.Cell(1, 1).Value = "Şehir";                           // Başlıklarımızı oluşturduk
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;                                              //2. satırdan başlasın her defasında bir artsın.
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }

                using (var stream = new MemoryStream())                      
                {
                    workbook.SaveAs(stream);                   //Streamden gelen Çalışma kitaplığımızı kaydetsin. 
                    var content = stream.ToArray();            //Bunu bir diziye dönüştürsün  
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YeniListe1.xlsx");   //Ve bunu döndük.
                }


            };
        }
    }
}
