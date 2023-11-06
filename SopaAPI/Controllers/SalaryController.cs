using Microsoft.AspNetCore.Mvc;
using SopaAPI.Data;
using SopaAPI.Model;
using SopaAPI.Services;

namespace SopaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalaryController : Controller
    {
        private readonly SalaryService _salaryService;
        private readonly IRepository<Salary> _salaryRepository;

        public SalaryController(SalaryService salaryService, IRepository<Salary> departementRepository)
        {
            _salaryService = salaryService;
            _salaryRepository = departementRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var salarys = _salaryService.GetAll();
            return Ok(salarys);
        }

        [HttpPost]
        public IActionResult Add(Salary salary) 
        { 
            if (ModelState.IsValid)
            {
                if (_salaryService.Save(salary))
                    return Created("", salary);
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Salary salary)
        {
            if (ModelState.IsValid)
            {
                if (_salaryService.Update(salary))
                    return NoContent();
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_salaryService.GetById(id) == null)
            {
                return NotFound();
            }
            else
            {
                if (_salaryService.Delete(id))
                    return NoContent();
                else
                    return BadRequest();
            }

        }
    }
}
