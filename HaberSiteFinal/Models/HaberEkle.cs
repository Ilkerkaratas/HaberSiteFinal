using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSiteFinal.Models
{
    public class HaberEkle
    {
        public String Name { get; set; }
        public string Description { get; set; }
        public IFormFile ImageURL { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
