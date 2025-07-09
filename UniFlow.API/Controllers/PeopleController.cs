using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniFlow.API.Models;

namespace UniFlow.API.Controllers;


[Route("api/People")]
[ApiController]
public class PeopleController : ControllerBase
{
    static List<Person> PeopleList = new List<Person>
    {
        new Person {ID = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1990, 1, 1), Address = "123 Main St", Phone = "3902139210", Gender = 'M', ImagePath = null},
        new Person {ID = 2, FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(1995, 5, 15), Address = "456 Elm St", Phone = "390213921", Gender = 'F', ImagePath = null},
        new Person {ID = 3, FirstName = "Alice", LastName = "Johnson", DateOfBirth = new DateTime(1988, 3, 20), Address = "789 Oak St", Phone = "390213", Gender = 'F', ImagePath = null},
    };

    [HttpGet(Name = "GetAllPeople")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<IEnumerable<Person>> GetAllPeople()
    {
        List<Person> people = PeopleList;

        if (people == null || people.Count == 0)
            return NotFound("No people found in the system");

        return Ok(people);

    }



}
