using DataAccess.Models;
using UniFlow.Shared.DTOs;

namespace BusinessLogic.Helpers;

public static class UserViewMapper
{
    public static UserViewDTO ToDTO(UserView userView)
    {
        return new UserViewDTO
        {
            UserId = userView.UserId,
            Username = userView.Username,
            PersonId = userView.PersonId,
            FullName = userView.FullName,
            RoleId = userView.RoleId,
            RoleName = userView.RoleName,
            Email = userView.Email,
            IsActive = userView.IsActive,
            LastLogin = userView.LastLogin,
            AccountCreated = userView.AccountCreated
        };
    }

    public static IEnumerable<UserViewDTO> ToDTOs(IEnumerable<UserView> userViews)
    {
        return userViews.Select(ToDTO);
    }
}