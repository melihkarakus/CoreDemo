using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        // Erişim Belirleyici , Değişken türü , İsim {get set}
        [Key]
        public int CategoryID { get; set; } //Prop yazarak kısayol direk eklenebilir.
        public string CategoryName { get; set; }
        public string CatergoryDescritption { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
