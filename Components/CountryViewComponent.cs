using Microsoft.AspNetCore.Mvc;

namespace B315_01_MVC6_SignUp_ClientSide_ServerSide.Components
{
    public class CountryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            List<string> countries = new List<string>() { "Australia", "India", "Portugal", "Russia", "Spain", "United States" };
            return View("~/Views/Components/_Countries.cshtml", countries);
        }
    }
}
