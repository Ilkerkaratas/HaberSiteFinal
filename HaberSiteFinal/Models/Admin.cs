using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSiteFinal.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [StringLength(20)]
        public String UserName { get; set; }
        [StringLength(20)]
        public String Password { get; set; }
     
    }
}
