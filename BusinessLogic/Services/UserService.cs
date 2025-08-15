using BusinessLogic.Interfaces;
using BusinessLogic.Helpers;
using DataAccess.Interfaces;
using UniFlow.Shared.DTOs.User;

namespace BusinessLogic.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllUsersAsync();
        return UserMapper.ToDTOs(users);
    }

    public async Task<UserDTO?> GetUserByIdAsync(int userId)
    {
        var user = await _userRepository.GetUserByIdAsync(userId);
        return user != null ? UserMapper.ToDTO(user) : null;
    }

    public async Task<UserDTO?> GetUserByUsernameAsync(string username)
    {
        var user = await _userRepository.GetUserByUsernameAsync(username);
        return user != null ? UserMapper.ToDTO(user) : null;
    }

    public async Task<int> AddUserAsync(UserDTO userDto)
    {
        var user = UserMapper.ToModel(userDto);
        return await _userRepository.AddUserAsync(user);
    }

    public async Task<bool> UpdateUserAsync(UserDTO userDto)
    {
        var user = UserMapper.ToModel(userDto);
        return await _userRepository.UpdateUserAsync(user);
    }

    public async Task<bool> UpdateUserPasswordAsync(int userId, string passwordHash)
    {
        return await _userRepository.UpdateUserPasswordAsync(userId, passwordHash);
    }

    public async Task<bool> UpdateUserLastLoginAsync(int userId)
    {
        return await _userRepository.UpdateUserLastLoginAsync(userId);
    }

    public async Task<bool> SetUserActiveStatusAsync(int userId, bool isActive)
    {
        return await _userRepository.SetUserActiveStatusAsync(userId, isActive);
    }

    public async Task<bool> DeleteUserAsync(int userId)
    {
        return await _userRepository.DeleteUserAsync(userId);
    }

    public async Task<IEnumerable<UserViewDTO>> GetAllUsersViewAsync()
    {
        var userViews = await _userRepository.GetAllUsersViewAsync();
        return UserViewMapper.ToDTOs(userViews);
    }

    public async Task<UserViewDTO?> GetUserViewByIdAsync(int userId)
    {
        var userView = await _userRepository.GetUserViewByIdAsync(userId);
        return userView != null ? UserViewMapper.ToDTO(userView) : null;
    }

    public async Task<UserViewDTO?> GetUserViewByUsernameAsync(string username)
    {
        var userView = await _userRepository.GetUserViewByUsernameAsync(username);
        return userView != null ? UserViewMapper.ToDTO(userView) : null;
    }
}