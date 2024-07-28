using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using OnlineShop.Domain.Contracts.People;
using OnlineShop.EndPoints.Models;
using System.Diagnostics;

namespace OnlineShop.EndPoints.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRepository personRepository;

        public HomeController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public IActionResult Index()
        {
            
            return View();
        }


      
    }
}
