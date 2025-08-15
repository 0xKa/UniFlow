using DataAccess.Models;
using UniFlow.Shared.DTOs;

namespace BusinessLogic.Helpers;

public static class UserMapper
{
    public static UserDTO ToDTO(User user)
    {
        return new UserDTO
        {
            UserId = user.UserId,
            PersonId = user.PersonId,
            RoleId = user.RoleId,
            Username = user.Username,
            PasswordHash = user.PasswordHash,
            Email = user.Email,
            IsActive = user.IsActive,
            LastLogin = user.LastLogin,
            AccountCreated = user.AccountCreated
        };
    }

    public static User ToModel(UserDTO userDto)
    {
        return new User
        {
            UserId = userDto.UserId,
            PersonId = userDto.PersonId,
            RoleId = userDto.RoleId,
            Username = userDto.Username,
            PasswordHash = userDto.PasswordHash,
            Email = userDto.Email,
            IsActive = userDto.IsActive,
            LastLogin = userDto.LastLogin,
            AccountCreated = userDto.AccountCreated
        };
    }

    public static IEnumerable<UserDTO> ToDTOs(IEnumerable<User> users)
    {
        return users.Select(ToDTO);
    }
}