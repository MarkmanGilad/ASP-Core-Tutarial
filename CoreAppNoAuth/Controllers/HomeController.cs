using CoreAppNoAuth.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;


namespace CoreAppNoAuth.Controllers
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
            //return Redirect("~/pages/testpage.html");
            return View();
        }

        public IActionResult Privacy()
        {
            //return View("Privacy");
            return View();
         }

        public IActionResult GiladPage()
        {
            return View();
        }

        public IActionResult UsersTable()
        {
            string SQL = "SELECT * FROM Users";
            DataSet ds = new DataSet();
            ds = Helper.RetrieveTable(SQL);
            return View(ds.Tables[0]);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}