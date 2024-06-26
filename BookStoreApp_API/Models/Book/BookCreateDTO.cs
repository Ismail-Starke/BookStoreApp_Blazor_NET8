﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApp_API.Models.Book
{
    public class BookCreateDTO
    {
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [Range(100, int.MaxValue)]
        public int Year { get; set; }

        [Required]
        public string Isbn { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 10)]
        public string Summary { get; set; }

        public string Image { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
    }
}
