using OnlineShop.Domain.Categorys;
using OnlineShop.Domain.People;
using OnlineShop.Domain.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.EndPoints.Models.People
{
	public abstract class AddNewPersonViewModel
	{
		[Required]
		[StringLength(50,MinimumLength =2)]
		public string FirstName { get; set; }
		[Required]
		[StringLength(50, MinimumLength = 2)]
		public string LastName { get; set; }
		[StringLength(500, MinimumLength = 2)]
		public string Address { get; set; }
		[Required]
		[EmailAddress]
		[StringLength(256, MinimumLength = 2)]
		public string Email { get; set; }
		public List<Product> products { get; set; }
	
		
	}
	public class AddNewPersonDisPlayViewModel : AddNewPersonViewModel
	{
		public List<Category> CategoriesForDisplay { get; set; }
	}
	public class AddNewPersonGetViewModel : AddNewPersonViewModel
	{
		public List<int> SelectedCategory { get; set; }
	}
}
