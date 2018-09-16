﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoohAPI.Models
{
    /// <summary>
    /// Class with review about a company without user id so the reviewer is anonymous.
    /// </summary>
    public class ReviewAnonymous
    {
        [Range(1.0, 5.0)]
        [Required]
        public double Stars { get; set; }
        public string WrittenReview { get; set; }
    }
}
