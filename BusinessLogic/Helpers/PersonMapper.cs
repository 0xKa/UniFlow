using DataAccess.Models;
using UniFlow.Shared.DTOs;
namespace BusinessLogic.Helpers;

public static class PersonMapper
{
    public static PersonDTO ToDTO(this Person p)
    {
        return new PersonDTO
        {
            ID = p.ID,
            FirstName = p.FirstName,
            LastName = p.LastName,
            DateOfBirth = p.DateOfBirth,
            Gender = p.Gender,
            Phone = p.Phone,
            Address = p.Address,
            NationalID = p.NationalID,
            ImagePath = p.ImagePath
        };
    }

    public static Person ToModel(this PersonDTO dto)
    {
        return new Person
        {
            ID = dto.ID,
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            DateOfBirth = dto.DateOfBirth,
            Gender = dto.Gender,
            Phone = dto.Phone,
            Address = dto.Address,
            NationalID = dto.NationalID,
            ImagePath = dto.ImagePath
        };
    }

}
