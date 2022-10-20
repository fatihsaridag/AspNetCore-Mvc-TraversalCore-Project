using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCore.Entity.Concrete
{
    //Müşteri bizim hakkımızda ne söyledi kısmı ?  Status değerine göre 4 veya başka bir değer viewde yayınlayacağız.
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string ClientImage { get; set; }
        public bool Status { get; set; }
    }
}
