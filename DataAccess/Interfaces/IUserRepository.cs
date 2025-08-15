using DataAccess.Models;

namespace DataAccess.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsersAsync();
    Task<User?> GetUserByIdAsync(int userId);
    Task<User?> GetUserByUsernameAsync(string username);
    Task<int> AddUserAsync(User user);
    Task<bool> UpdateUserAsync(User user);
    Task<bool> UpdateUserPasswordAsync(int userId, string passwordHash);
    Task<bool> UpdateUserLastLoginAsync(int userId);
    Task<bool> SetUserActiveStatusAsync(int userId, bool isActive);
    Task<bool> DeleteUserAsync(int userId);

    // View methods
    Task<IEnumerable<UserView>> GetAllUsersViewAsync();
    Task<UserView?> GetUserViewByIdAsync(int userId);
    Task<UserView?> GetUserViewByUsernameAsync(string username);
}
