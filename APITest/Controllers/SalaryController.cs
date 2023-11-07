using APITest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APITest.Controllers
{
    public class SalaryController : Controller
    {
        public async Task<IActionResult> Index()
        {

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("");

            if (response.IsSuccessStatusCode) 
            { 
                var jsonstr = await response.Content.ReadAsStringAsync();
                List<Salary> salaries = JsonConvert.DeserializeObject<List<Salary>>(jsonstr);

                return View(salaries);
            }

            return View(new List<Salary>());
        }
    }
}
