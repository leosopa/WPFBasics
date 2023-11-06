using Microsoft.AspNetCore.Mvc;
using SopaAPI.Data;
using SopaAPI.Model;
using SopaAPI.Services;

namespace SopaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly PersonService _personService;
        private readonly IRepository<Person> _personRepository;

        public PersonController(PersonService personService, IRepository<Person> departementRepository)
        {
            _personService = personService;
            _personRepository = departementRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var persons = _personService.GetAll();
            return Ok(persons);
        }

        [HttpPost]
        public IActionResult Add(Person person) 
        { 
            if (ModelState.IsValid)
            {
                if (_personService.Save(person))
                    return Created("", person);
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Person person)
        {
            if (ModelState.IsValid)
            {
                if (_personService.Update(person))
                    return NoContent();
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_personService.GetById(id) == null)
            {
                return NotFound();
            }
            else
            {
                if (_personService.Delete(id))
                    return NoContent();
                else
                    return BadRequest();
            }

        }
    }
}
