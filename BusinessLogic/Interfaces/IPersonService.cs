using UniFlow.DTOs;

namespace BusinessLogic.Interfaces;

public interface IPersonService
{
    List<PersonDTO> GetAll();
    PersonDTO? GetById(int id);
    int Add(PersonDTO dto);
    bool Update(PersonDTO dto);
    bool Delete(int id);

    List<PersonViewDTO> GetAllFromView();

}
