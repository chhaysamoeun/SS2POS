﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace SS2POS.Models
{
	public class ProductDTO
	{
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public IFormFile Image { get; set; }

        public Category Category { get; set; }
    }
}
