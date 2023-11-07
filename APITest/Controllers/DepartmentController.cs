using APITest.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace APITest.Controllers
{
    public class DepartmentController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Department> departmentList = new List<Department>();
            HttpClient client = new HttpClient();

            HttpResponseMessage httpResponseMessage = await client.GetAsync("http://localhost:5099/api/Department");

            if (httpResponseMessage.IsSuccessStatusCode) 
            {
                var jsonstr = await httpResponseMessage.Content.ReadAsStringAsync();
                departmentList = JsonConvert.DeserializeObject<List<Department>>(jsonstr);
                return View(departmentList);
            }

            return View(departmentList);
        }

        public IActionResult Add() 
        {
            return View();
        }
    }
}
