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



}
