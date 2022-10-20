using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversalCore.Entity.Concrete
{

    // Öne çıkan alanlar küçük 4 fotoğraf için , Statusu true olan 4 tane değer çekicez ve view de göstericez.
    public class Feature2
    {
        [Key]
        public int Feature2Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
    