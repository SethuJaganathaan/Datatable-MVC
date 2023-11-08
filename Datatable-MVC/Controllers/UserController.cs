using Datatable_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Datatable_MVC.Controllers
{
    public class UserController : Controller
    {
        private static List<User> GetSampleUsers()
        {
            var users = new List<User>
            {
                new User {Id = 1, Name= "Luffy", Details = "gfhtfg"},
                new User {Id = 2, Name= "Zoro", Details = "2313213"},
                new User {Id = 3, Name= "Sanji", Details = "gfhtefweewrgfg"}
            };
            return users;
        }

        public IActionResult GetUserData()
        {
            return View("UserData");
        }

        public IActionResult GetUserDetailsData()
        {
            List<User> usersDetails = GetSampleUsers();
            var jsonData = new
            {
                data = usersDetails.Select(x => new
                {
                    id = x.Id,
                    name = x.Name,
                    details = x.Details
                })
            };

            return Json(new {data = usersDetails});
        }
    }
}
