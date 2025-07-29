using BusinessLogic.Interfaces;
using UniFlow.DTOs;
using DataAccess.Interfaces;
using DataAccess.Models;
using BusinessLogic.Helpers;

namespace BusinessLogic.Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public List<PersonDTO> GetAll()
    {
        List<Person> people = _personRepository.GetAll();
        return people.Select(p => p.ToDTO()).ToList();
    }


    public PersonDTO? GetById(int id)
    {
        Person? person = _personRepository.GetById(id);
        return person?.ToDTO();
    }


    public int Add(PersonDTO dto)
    {
        Person person = dto.ToModel();
        int id = _personRepository.Add(person);
        return id;
    }

    public bool Update(PersonDTO dto)
    {
        Person person = dto.ToModel();
        return _personRepository.Update(person);
    }

    public bool Delete(int id)
    {
        return _personRepository.Delete(id);
    }

    public List<PersonViewDTO> GetAllFromView()
    {
        List<PersonView> people = _personRepository.GetAllFromView();
        return people.Select(p => p.ToDTO()).ToList();
    }

}
