using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCore.Entity.Concrete
{
    //About sayfasının 1. alanı
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description1 { get; set; }
        public string Image1 { get; set; }
        public string Title2 { get; set; } //Neden bizi seçmelisin başlığı
        public string Description2 { get; set; } //Neden bizi seçmelisin Açıklaması
        public bool Status { get; set; }
    }
}
