using Cat_Adoption.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

namespace Cat_Adoption.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AdoptionDbContext _AdoptionDbContext = new AdoptionDbContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //List<Cat> result = _AdoptionDbContext.Cats.ToList();
            List<string> breeds = _AdoptionDbContext.Cats.Select(x => x.Breed).Distinct().ToList();
            return View(breeds);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Results(string Breed)//takes the value from the form name
        {
            List<Cat> result = _AdoptionDbContext.Cats.Where(x => x.Breed == Breed).ToList();
            //gets the post with the matching id and returns it to the view

            return View(result);
        }
        public IActionResult Add()
        {

            return View();
        }

    public IActionResult Adopt(int id)
        {
            Cat result = _AdoptionDbContext.Cats.FirstOrDefault(x => x.Id == id);
            _AdoptionDbContext.Cats.Remove(result);
            _AdoptionDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult addCat(Cat c)
            {
            _AdoptionDbContext.Cats.Add(c);
            _AdoptionDbContext.SaveChanges();
            return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}