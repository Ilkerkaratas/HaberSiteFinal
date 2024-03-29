﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HaberSiteFinal.Models
{
    public class Haber
    {
        public int HaberID { get; set; }
        public string HaberName { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}

