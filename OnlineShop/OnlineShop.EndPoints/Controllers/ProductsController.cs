using Microsoft.AspNetCore.Mvc;
using OnlineShop.Domain.Contracts.Products;
using OnlineShop.Domain.People;
using OnlineShop.Domain.Products;
using OnlineShop.EndPoints.Models.People;
using OnlineShop.EndPoints.Models.Pruduct;
using OnlineShop.Infrastructure.DataAccess.Categorys;
using OnlineShop.Infrastructure.DataAccess.People;

namespace OnlineShop.EndPoints.Controllers
{
	public class ProductsController : Controller
	{
		private readonly IProductRepository productRepository;

		public ProductsController(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}

		public IActionResult Index()
		{
			var products = productRepository.GetAll().ToList();
			return View(products);
		}
	
	
		public IActionResult Add(AddNewProductViewModel model)
		{
			if (ModelState.IsValid)

			{
				Product product = new Product
				{
					Name = model.Name
				};

				productRepository.Add(product);
				
			}

			AddNewProductViewModel modelfordisplay = new AddNewProductViewModel
			{
				Name = model.Name
			};
			

			return View(modelfordisplay);
		}
	}
}
