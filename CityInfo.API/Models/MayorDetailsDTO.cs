﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class MayorDetailsDTO
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
