using UniFlow.Shared.DTOs;

namespace BusinessLogic.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDTO>> GetAllUsersAsync();
    Task<UserDTO?> GetUserByIdAsync(int userId);
    Task<UserDTO?> GetUserByUsernameAsync(string username);
    Task<int> AddUserAsync(UserDTO userDto);
    Task<bool> UpdateUserAsync(UserDTO userDto);
    Task<bool> UpdateUserPasswordAsync(int userId, string passwordHash);
    Task<bool> UpdateUserLastLoginAsync(int userId);
    Task<bool> SetUserActiveStatusAsync(int userId, bool isActive);
    Task<bool> DeleteUserAsync(int userId);

    // View methods
    Task<IEnumerable<UserViewDTO>> GetAllUsersViewAsync();
    Task<UserViewDTO?> GetUserViewByIdAsync(int userId);
    Task<UserViewDTO?> GetUserViewByUsernameAsync(string username);
}