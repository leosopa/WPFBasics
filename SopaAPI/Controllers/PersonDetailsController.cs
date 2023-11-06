using Microsoft.AspNetCore.Mvc;
using SopaAPI.Data;
using SopaAPI.Model;
using SopaAPI.Services;

namespace SopaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonDetailsController : Controller
    {
        private readonly PersonDetailsService _personDetailsService;
        private readonly IRepository<PersonDetails> _personDetailsRepository;

        public PersonDetailsController(PersonDetailsService personDetailsService, IRepository<PersonDetails> departementRepository)
        {
            _personDetailsService = personDetailsService;
            _personDetailsRepository = departementRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var personDetailss = _personDetailsService.GetAll();
            return Ok(personDetailss);
        }

        [HttpPost]
        public IActionResult Add(PersonDetails personDetails) 
        { 
            if (ModelState.IsValid)
            {
                if (_personDetailsService.Save(personDetails))
                    return Created("", personDetails);
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(PersonDetails personDetails)
        {
            if (ModelState.IsValid)
            {
                if (_personDetailsService.Update(personDetails))
                    return NoContent();
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_personDetailsService.GetById(id) == null)
            {
                return NotFound();
            }
            else
            {
                if (_personDetailsService.Delete(id))
                    return NoContent();
                else
                    return BadRequest();
            }

        }
    }
}
