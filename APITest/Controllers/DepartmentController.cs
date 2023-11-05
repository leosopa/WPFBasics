using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add() 
        {
            return View();
        }
    }
}
