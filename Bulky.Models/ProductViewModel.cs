﻿using Bulky.Models.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bulky.Models
{
    public class ProductViewModel
	{
		public Product product { get; set; }
		[ValidateNever]	
		public IEnumerable<SelectListItem> CategoryList { get; set; } = default!;
	}
}
