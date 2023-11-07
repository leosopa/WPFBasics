using APITest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APITest.Controllers
{
    public class PersonController : Controller
    {
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://localhost:5099/api/Person/GetFullPersons");
            if (response.IsSuccessStatusCode)
            {
                var jsonstr = await response.Content.ReadAsStringAsync();
                List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(jsonstr);

                return View(persons);
            }

            return View(new List<Person>());
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
