using Microsoft.AspNetCore.Mvc;
using PeopleManager.Cyb.Ui.Mvc.Models;
using System.Diagnostics;

namespace PeopleManager.Cyb.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new Person {FirstName = "Bavo", LastName = "Ketels", Email = "bavo.ketels@gmail.com"},
                new Person {FirstName = "Bavo2", LastName = "Ketels2", Email = "bavo.ketels2@gmail.com"},
                new Person {FirstName = "Bavo3", LastName = "Ketels3", Email = "bavo.ketels3@gmail.com"},
                new Person {FirstName = "Bavo4", LastName = "Ketels4", Email = "bavo.ketels4@gmail.com"},
            };
        }
    }
}