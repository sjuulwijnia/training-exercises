using Entities;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using System.Linq;

namespace RestAPI.Controllers
{
    [Route("persons")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personService)
        {
            _personRepository = personService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll([FromQuery] int? skip = null, [FromQuery] int? take = null)
        {
            return Ok(_personRepository.Get()
                .Skip(skip ?? 0)
                .Take(take ?? 25)
                .ToList()
            );
        }

        [HttpGet]
        [Route("{personId}")]
        public IActionResult GetPersonById(int personId)
        {
            var person = _personRepository.GetById(personId);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPut]
        [Route("{personId}")]
        public IActionResult PutPersonById([FromBody] Person person)
        {
            var updated = _personRepository.Update(person);
            if (!updated)
            {
                return NotFound();
            }

            return Accepted(person);
        }

        [HttpPost]
        [Route("")]
        public IActionResult PostPerson([FromBody] Person person)
        {
            var created = _personRepository.Insert(person);
            if (!created)
            {
                return BadRequest();
            }

            //return CreatedAtRoute("{personId}", new { personId = person.Id }, person);
            return CreatedAtAction(nameof(GetPersonById), new { personId = person.Id }, person);
        }

        [HttpDelete]
        [Route("{personId}")]
        public IActionResult DeletePersonById(int personId)
        {
            var deleted = _personRepository.Delete(personId);
            if (!deleted)
            {
                return NotFound();
            }

            return Accepted();
        }
    }
}
