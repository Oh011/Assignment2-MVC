using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index"); //->  Html + c# Index.CsHtml
        }


        [HttpGet("AboutUs")]

        public IActionResult AboutUs()
        {

            return View();
        }


        [HttpGet("ContactUs")]


        public IActionResult ContactUs()
        {

            return View();
        }


        [HttpGet("Privacy")]

        public IActionResult Privacy()
        {

            return View();
        }
    }
}
