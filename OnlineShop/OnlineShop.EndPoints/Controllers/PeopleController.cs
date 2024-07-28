using Microsoft.AspNetCore.Mvc;
using OnlineShop.Domain.Contracts.Categorys;
using OnlineShop.Domain.Contracts.People;
using OnlineShop.EndPoints.Models.People;
using OnlineShop.Infrastructure.DataAccess.People;
using OnlineShop.Domain.People;
using OnlineShop.Domain.Products;
using OnlineShop.Domain.Contracts.Products;

namespace OnlineShop.EndPoints.Controllers
{
    public class PeopleController : Controller
    {
		private readonly ICategoryRepository categoryRepository;
		private readonly IPersonRepository personRepository;
	

		public PeopleController(ICategoryRepository categoryRepository, IPersonRepository personRepository )
		{
			this.categoryRepository = categoryRepository;
			this.personRepository = personRepository;
			
		}

		public IActionResult Index()
        {
            var people = personRepository.GetAll().ToList();
 

			return View(people);
        }
        public IActionResult Add()
        {
			AddNewPersonDisPlayViewModel model = new AddNewPersonDisPlayViewModel();
            model.CategoriesForDisplay = categoryRepository.GetAll().ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(AddNewPersonGetViewModel model)
        {
            if(ModelState.IsValid)

            {
                Person person = new Person
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    Email = model.Email,
                    Categories = new List<PersonCategory>(model.SelectedCategory.Select(c => new PersonCategory
                    {
                        CategoryId = c
                    }).ToList()),
                 
                    
                    
                };
                personRepository.Add(person);
                return RedirectToAction("Index");
            }

			AddNewPersonDisPlayViewModel modelfordisplay = new AddNewPersonDisPlayViewModel
            {
				Address=model.Address,
                FirstName=model.FirstName,
                LastName=model.LastName,
                Email=model.Email
            };
			modelfordisplay.CategoriesForDisplay = categoryRepository.GetAll().ToList();

			return View(modelfordisplay);
        }
    }
}
