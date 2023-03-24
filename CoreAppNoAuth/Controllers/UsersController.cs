using CoreAppNoAuth.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppNoAuth.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            User user = new User();
            user.id = 6;
            user.Username = "test";
            user.Pass = "testPass";
            user.Firstname = "first";
            user.Lastname = "last";
            return View(user);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(User user)
        {
            int n = Helper.Insert(user);
            return Redirect("../Home");
        }
    }
}
