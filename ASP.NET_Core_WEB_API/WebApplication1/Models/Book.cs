﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        public ushort Year { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int PublisherId { get; set; }
    }
}
