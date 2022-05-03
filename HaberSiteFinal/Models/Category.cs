using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSiteFinal.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Category Name Not Empty")]
        [StringLength(20, ErrorMessage = "Please only enter 4-20 lengh characters ", MinimumLength = 4)]
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }
        public bool Status { get; set; }
        public List<Haber> habers { get; set; }
    }
}
