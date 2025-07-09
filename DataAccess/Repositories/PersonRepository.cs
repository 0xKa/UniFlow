using System.Data;
using Microsoft.Data.SqlClient;
using DataAccess.Interfaces;
using DataAccess.Models;

namespace DataAccess.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly string _connectionString;

    public PersonRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Person> GetAll()
    {
        var people = new List<Person>();

        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand("usp_GetAllPeople", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        conn.Open();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            people.Add(ReadPerson(reader));
        }

        return people;
    }

    public Person? GetById(int id)
    {
        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand("usp_GetPersonById", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@PersonId", id);

        conn.Open();
        using var reader = cmd.ExecuteReader();
        if (reader.Read())
            return ReadPerson(reader);

        return null;
    }

    public int Add(Person person)
    {
        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand("usp_AddPerson", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
        cmd.Parameters.AddWithValue("@LastName", person.LastName);
        cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
        cmd.Parameters.AddWithValue("@Gender", person.Gender);
        cmd.Parameters.AddWithValue("@Phone", person.Phone);
        cmd.Parameters.AddWithValue("@Address", (object?)person.Address ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@NationalId", person.NationalID);
        cmd.Parameters.AddWithValue("@ImagePath", (object?)person.ImagePath ?? DBNull.Value);

        var outputId = new SqlParameter("@NewPersonId", SqlDbType.Int)
        {
            Direction = ParameterDirection.Output
        };
        cmd.Parameters.Add(outputId);

        conn.Open();
        cmd.ExecuteNonQuery();

        return (int)outputId.Value;
    }

    public bool Update(Person person)
    {
        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand("usp_UpdatePerson", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@PersonId", person.ID);
        cmd.Parameters.AddWithValue("@FirstName", person.FirstName);
        cmd.Parameters.AddWithValue("@LastName", person.LastName);
        cmd.Parameters.AddWithValue("@DateOfBirth", person.DateOfBirth);
        cmd.Parameters.AddWithValue("@Gender", person.Gender);
        cmd.Parameters.AddWithValue("@Phone", person.Phone);
        cmd.Parameters.AddWithValue("@Address", (object?)person.Address ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@NationalId", person.NationalID);
        cmd.Parameters.AddWithValue("@ImagePath", (object?)person.ImagePath ?? DBNull.Value);

        conn.Open();
        try
        {
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
        catch
        {
            return false;
        }
    }

    public bool Delete(int id)
    {
        using var conn = new SqlConnection(_connectionString);
        using var cmd = new SqlCommand("usp_DeletePerson", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@PersonId", id);

        conn.Open();
        return cmd.ExecuteNonQuery() > 0;
    }

    private Person ReadPerson(SqlDataReader reader)
    {
        return new Person
        {
            ID = Convert.ToInt32(reader["person_id"]),
            FirstName = reader["first_name"].ToString()!,
            LastName = reader["last_name"].ToString()!,
            DateOfBirth = Convert.ToDateTime(reader["date_of_birth"]),
            Gender = Convert.ToChar(reader["gender"]),
            Phone = reader["phone"].ToString()!,
            Address = reader["address"] == DBNull.Value ? null : reader["address"].ToString(),
            NationalID = reader["national_id"].ToString()!,
            ImagePath = reader["image_path"] == DBNull.Value ? null : reader["image_path"].ToString()
        };
    }
}
