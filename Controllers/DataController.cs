using B315_01_MVC6_SignUp_ClientSide_ServerSide.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace B315_01_MVC6_SignUp_ClientSide_ServerSide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        [Route("Countries")]
        public List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();

            countries.Add(new Country { CountryID = 1, CountryName = "Australia" });
            countries.Add(new Country { CountryID = 2, CountryName = "India" });
            //countries.Add(new Country { CountryID = 3, CountryName = "Portugal" });
            //countries.Add(new Country { CountryID = 4, CountryName = "Russia" });
            //countries.Add(new Country { CountryID = 5, CountryName = "Spain" });
            //countries.Add(new Country { CountryID = 6, CountryName = "United States" });

            return countries;
        }

        [HttpGet]
        [Route("Cities")]
        public List<City> GetCityByCountry(int CountryID)
        {
            List<City> cities = new List<City>();

            cities.Add(new City { CityID = 1, CityName = "Sydney", CountryID = 1 });
            cities.Add(new City { CityID = 2, CityName = "Melbourne", CountryID = 1 });
            cities.Add(new City { CityID = 3, CityName = "Brisbane", CountryID = 1 });

            cities.Add(new City { CityID = 4, CityName = "Delhi", CountryID = 2 });
            cities.Add(new City { CityID = 5, CityName = "Mumbai", CountryID = 2 });
            cities.Add(new City { CityID = 6, CityName = "Chennai", CountryID = 2 });
            cities.Add(new City { CityID = 7, CityName = "Kolkata", CountryID = 2 });

            return cities.Where(City => City.CountryID == CountryID).ToList();
        }
    }
}
