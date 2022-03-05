using B315_01_MVC6_SignUp_ClientSide_ServerSide.Models;
using Microsoft.AspNetCore.Mvc;

namespace B315_01_MVC6_SignUp_ClientSide_ServerSide.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ThankYou", "Customer");
            }
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
