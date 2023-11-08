using Datatable_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Datatable_MVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var users = GetSampleUsers();
            return View(users);
        }

        public IActionResult GetUserDetailsData(int id)
        {
            Person user = GetUserDetailsById(id);
            return Json(user);
        }

        private List<Person> GetSampleUsers()
        {
            var users = new List<Person>
            {
                new Person { Id = 1, Name = "Luffy", Email = "luffy@gmail.com" },
                new Person { Id = 2, Name = "Zoro", Email = "zoro@gmail.com" },
                new Person { Id = 3, Name = "Sanji", Email = "sanji@gmail.com" },
            };

            return users;
        }

        private Person GetUserDetailsById(int id)
        {

            var users = GetSampleUsers();
            Person user = users.FirstOrDefault(u => u.Id == id);
            return user;
        }
    }
}
