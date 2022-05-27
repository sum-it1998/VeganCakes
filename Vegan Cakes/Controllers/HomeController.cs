using Microsoft.AspNetCore.Mvc;
using Vegan_Cakes.Models;
using Vegan_Cakes.ViewModels;

namespace Vegan_Cakes.Controllers
{


    public class HomeController : Controller
    {
        private readonly ICakeRepository repository;

        public HomeController(ICakeRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Index()
        {
            var cakes = repository.getAllCakes();
            HomeViewModel model = new HomeViewModel()
            {
                Title = "Welcome to Home",
                Cakes = cakes
            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var cake = repository.getcakeById(id);
            
            return View(cake);
        }
    }
}
