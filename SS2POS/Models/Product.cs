using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SS2POS.Models
{
	public class Product
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
		public string Image { get; set; }
		[Required]
		[MaxLength(10)]
		public string Barcode { get; set; }
		public Category Category { get; set; }
	}
}

