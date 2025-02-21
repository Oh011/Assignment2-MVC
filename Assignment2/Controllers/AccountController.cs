using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    public class AccountController : Controller
    {
      
            public IActionResult Login()
            {
                return View();
            }


            public IActionResult Register()
            {
                return View();
            }
        
    }
}
