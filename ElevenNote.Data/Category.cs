﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
