namespace UniFlow.Shared.DTOs;

public class PersonViewDTO
{
    public int PersonID { get; set; }
    public string NationalID { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
}