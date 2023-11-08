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
            User user = GetUserDetailsById(id);
            return Json(user);
        }

        private List<User> GetSampleUsers()
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "Luffy", Details = "luffy@gmail.com" },
                new User { Id = 2, Name = "Zoro", Details = "zoro@gmail.com" },
                new User { Id = 3, Name = "Sanji", Details = "sanji@gmail.com" },
            };

            return users;
        }

        private User GetUserDetailsById(int id)
        {

            var users = GetSampleUsers();
            User user = users.FirstOrDefault(u => u.Id == id);
            return user;
        }
    }
}
