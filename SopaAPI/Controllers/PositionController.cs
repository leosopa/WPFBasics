using Microsoft.AspNetCore.Mvc;
using SopaAPI.Data;
using SopaAPI.Model;
using SopaAPI.Services;

namespace SopaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionController : Controller
    {
        private readonly PositionService _positionService;
        private readonly IRepository<Position> _positionRepository;

        public PositionController(PositionService positionService, IRepository<Position> departementRepository)
        {
            _positionService = positionService;
            _positionRepository = departementRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var positions = _positionService.GetAll();
            return Ok(positions);
        }

        [HttpPost]
        public IActionResult Add(Position position) 
        { 
            if (ModelState.IsValid)
            {
                if (_positionService.Save(position))
                    return Created("", position);
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Update(Position position)
        {
            if (ModelState.IsValid)
            {
                if (_positionService.Update(position))
                    return NoContent();
                else
                    return BadRequest();
            }
            return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_positionService.GetById(id) == null)
            {
                return NotFound();
            }
            else
            {
                if (_positionService.Delete(id))
                    return NoContent();
                else
                    return BadRequest();
            }

        }
    }
}
