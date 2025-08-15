namespace UniFlow.Shared.DTOs;

public class UserDTO
{
    public int UserId { get; set; }
    public int PersonId { get; set; }
    public int RoleId { get; set; }
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime? LastLogin { get; set; }
    public DateTime AccountCreated { get; set; }
}