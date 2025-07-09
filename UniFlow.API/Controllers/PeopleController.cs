using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BusinessLogic.Interfaces;
using UniFlow.DTOs;

namespace UniFlow.API.Controllers;


[Route("api/People")]
[ApiController]
public class PeopleController : ControllerBase
{
    private readonly IPersonService _personService;

    public PeopleController(IPersonService personService)
    {
        _personService = personService;
    }


    [HttpGet(Name = "GetAllPeople")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<IEnumerable<PersonDTO>> GetAllPeople()
    {
        List<PersonDTO> people = _personService.GetAll();

        if (people == null || people.Count == 0)
            return NotFound("No people found in the system");

        return Ok(people);

    }

    // GET: api/People/5
    [HttpGet("{id:int}", Name = "GetPersonById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<PersonDTO> GetPersonById(int id)
    {
        var person = _personService.GetById(id);

        if (person == null)
            return NotFound($"Person with ID {id} not found.");

        return Ok(person);
    }

    // POST: api/People
    [HttpPost(Name = "AddPerson")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<PersonDTO> AddPerson([FromBody] PersonDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        int newId = _personService.Add(dto);
        dto.ID = newId;

        return CreatedAtRoute("GetPersonById", new { id = newId }, dto);
    }


    // PUT: api/People/5
    [HttpPut("{id:int}", Name = "UpdatePerson")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public IActionResult UpdatePerson(int id, [FromBody] PersonDTO dto)
    {
        if (id != dto.ID)
            return BadRequest("ID in URL does not match ID in body.");

        var existing = _personService.GetById(id);
        if (existing == null)
            return NotFound($"Person with ID {id} not found.");

        bool updated = _personService.Update(dto);
        if (!updated)
            return StatusCode(500, "Failed to update person.");

        return Ok("Person updated successfully.");
    }

    // DELETE: api/People/5
    [HttpDelete("{id:int}", Name = "DeletePerson")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeletePerson(int id)
    {
        var existing = _personService.GetById(id);
        if (existing == null)
            return NotFound($"Person with ID {id} not found.");

        bool deleted = _personService.Delete(id);
        if (!deleted)
            return StatusCode(500, "Failed to delete person.");

        return Ok("Person deleted successfully.");
    }


}
