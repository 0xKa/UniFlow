using DataAccess.Models;

namespace DataAccess.Interfaces;

public interface IPersonRepository
{
    List<Person> GetAll();
    Person? GetById(int id);
    int Add(Person person);
    bool Update(Person person);
    bool Delete(int id);
}