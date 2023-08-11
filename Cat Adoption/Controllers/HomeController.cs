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
            List<Cat> result = _AdoptionDbContext.Cats.ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Results(string Breed)
        {
            List<Cat> p = _AdoptionDbContext.Cats.Where(x => x.Breed == Breed).ToList();
            //gets the post with the matching id and returns it to the view

            return View(p);
        }
        public IActionResult RemoveAnimal(int id)
        {
            Cat a = _AdoptionDbContext.Cats.FirstOrDefault(x => x.Id == id);
            _AdoptionDbContext.Cats.Remove(a);
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