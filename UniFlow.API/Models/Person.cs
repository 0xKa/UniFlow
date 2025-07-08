namespace UniFlow.API.Models;

public class Person
{
    public int ID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public char Gender { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string? Address { get; set; }
    public string NationalID { get; set; } = string.Empty;
    public string? ImagePath { get; set; }


}
