using OnlineShop.Domain.Categorys;
using OnlineShop.Domain.People;
using OnlineShop.Domain.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EndPoints.Models.Pruduct
{
	public class AddNewProductViewModel
	{
		[Required]
		[StringLength(100, MinimumLength =  1)]
		public string Name { get; set; }
	}
}
