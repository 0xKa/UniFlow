using DataAccess.Models;
using UniFlow.Shared.DTOs;

namespace BusinessLogic.Helpers;

public static class PersonViewMapper
{
    public static PersonViewDTO ToDTO(this PersonView pv)
    {
        return new PersonViewDTO
        {
            PersonID = pv.PersonID,
            NationalID = pv.NationalID,
            FullName = pv.FullName,
            DateOfBirth = pv.DateOfBirth,
            Age = pv.Age,
            Gender = pv.Gender,
            Phone = pv.Phone
        };
    }
}