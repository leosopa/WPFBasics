using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    public class SalaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
