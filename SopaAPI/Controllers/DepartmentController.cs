using Microsoft.AspNetCore.Mvc;
using SopaAPI.Data;
using SopaAPI.Model;
using SopaAPI.Services;

namespace SopaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly DepartmentService _departmentService;
        private readonly IRepository<Department> _departmentRepository;

        public DepartmentController(DepartmentService departmentService, IRepository<Department> departementRepository)
        {
            _departmentService = departmentService;
            _departmentRepository = departementRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var departments = _departmentService.GetAll();
            return Ok(departments);
        }

        [HttpPost]
        public IActionResult Add(Department department) 
        { 
            if (ModelState.IsValid)
            {
                if (_departmentService.Save(department))
                    return Created("", department);
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Department department)
        {
            if (ModelState.IsValid)
            {
                if (_departmentService.Update(department))
                    return NoContent();
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_departmentService.GetById(id) == null)
            {
                return NotFound();
            }
            else
            {
                if (_departmentService.Delete(id))
                    return NoContent();
                else
                    return BadRequest();
            }

        }
    }
}
