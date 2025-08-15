namespace UniFlow.Shared.DTOs;

public class UserViewDTO
{
    public int UserId { get; set; }
    public string Username { get; set; } = string.Empty;
    public int PersonId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public int RoleId { get; set; }
    public string RoleName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime? LastLogin { get; set; }
    public DateTime AccountCreated { get; set; }
}