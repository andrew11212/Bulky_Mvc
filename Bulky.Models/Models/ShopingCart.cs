﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models.Models
{
	public class ShopingCart
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public int ProductId { get; set; }
		[ValidateNever]
		[ForeignKey("ProductId")]
		public Product Product { get; set; } = default!;
		[Range(1, 1000 ,ErrorMessage ="Value must be from 1 to 1000")]
		public int Count { get; set; }

		public string ApplicationUserId { get; set; } =string.Empty;
		[ValidateNever]
		[ForeignKey("ApplicationUserId")]
		public ApplicationUser ApplicationUser { get; set; } = default!;

		[NotMapped]
		public double price {  get; set; }
	}
}
