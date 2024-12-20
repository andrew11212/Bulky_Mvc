﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models.Models
{
	public class OrderHeader
	{
		public int Id { get; set; }

		public string ApplicationUserId { get; set; } = string.Empty;
		[ForeignKey(nameof(ApplicationUserId))]
		public ApplicationUser ApplicationUser { get; set; } = default!;

		public DateTime OrderDate { get; set; }

		public DateTime ShippingDate { get; set; }

		public double OrderTotal { get; set; }

		public string? OrderStatus { get; set; }
		public string? PaymentStatus { get; set; }
			
		public DateTime? PaymentDate { get; set; }
		public DateOnly? PaymentDueDate { get; set; }

		public string? PaymentIntentId { get; set; }
		public string? Name { get; set; } = string.Empty;
		public string? Address { get; set; } = string.Empty;
		public string? City { get; set; } = string.Empty;
		public string? State { get; set; } = string.Empty;
		public string? PostalCode { get; set; } = string.Empty;

		public string? PhoneNumber { get; set; } = string.Empty;

	}
}
