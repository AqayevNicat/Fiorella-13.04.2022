﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
    }
}
