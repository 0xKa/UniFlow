using DataAccess.Interfaces;
using DataAccess.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private readonly string _connectionString;

    public UserRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentNullException(nameof(configuration));
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        var users = new List<User>();

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_GetAllUsers", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            users.Add(MapUserFromReader(reader));
        }

        return users;
    }

    public async Task<User?> GetUserByIdAsync(int userId)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_GetUserById", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@UserId", userId);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return MapUserFromReader(reader);
        }

        return null;
    }

    public async Task<User?> GetUserByUsernameAsync(string username)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_GetUserByUsername", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@Username", username);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return MapUserFromReader(reader);
        }

        return null;
    }

    public async Task<int> AddUserAsync(User user)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_AddUser", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@PersonId", user.PersonId);
        command.Parameters.AddWithValue("@RoleId", user.RoleId);
        command.Parameters.AddWithValue("@Username", user.Username);
        command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
        command.Parameters.AddWithValue("@Email", user.Email);
        command.Parameters.AddWithValue("@IsActive", user.IsActive);

        var outputParam = new SqlParameter("@NewUserId", SqlDbType.Int)
        {
            Direction = ParameterDirection.Output
        };
        command.Parameters.Add(outputParam);

        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();

        return (int)outputParam.Value;
    }

    public async Task<bool> UpdateUserAsync(User user)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_UpdateUser", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@UserId", user.UserId);
        command.Parameters.AddWithValue("@PersonId", user.PersonId);
        command.Parameters.AddWithValue("@RoleId", user.RoleId);
        command.Parameters.AddWithValue("@Username", user.Username);
        command.Parameters.AddWithValue("@Email", user.Email);
        command.Parameters.AddWithValue("@IsActive", user.IsActive);

        await connection.OpenAsync();

        try
        {
            await command.ExecuteNonQueryAsync();
            return true;
        }
        catch (SqlException)
        {
            return false;
        }
    }

    public async Task<bool> UpdateUserPasswordAsync(int userId, string passwordHash)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_UpdateUserPassword", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@UserId", userId);
        command.Parameters.AddWithValue("@PasswordHash", passwordHash);

        await connection.OpenAsync();

        try
        {
            await command.ExecuteNonQueryAsync();
            return true;
        }
        catch (SqlException)
        {
            return false;
        }
    }

    public async Task<bool> UpdateUserLastLoginAsync(int userId)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_UpdateUserLastLogin", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@UserId", userId);

        await connection.OpenAsync();

        try
        {
            await command.ExecuteNonQueryAsync();
            return true;
        }
        catch (SqlException)
        {
            return false;
        }
    }

    public async Task<bool> SetUserActiveStatusAsync(int userId, bool isActive)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_SetUserActiveStatus", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@UserId", userId);
        command.Parameters.AddWithValue("@IsActive", isActive);

        await connection.OpenAsync();

        try
        {
            await command.ExecuteNonQueryAsync();
            return true;
        }
        catch (SqlException)
        {
            return false;
        }
    }

    public async Task<bool> DeleteUserAsync(int userId)
    {
        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand("usp_DeleteUser", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@UserId", userId);

        await connection.OpenAsync();

        try
        {
            await command.ExecuteNonQueryAsync();
            return true;
        }
        catch (SqlException)
        {
            return false;
        }
    }

    private static User MapUserFromReader(SqlDataReader reader)
    {
        return new User
        {
            UserId = reader.GetInt32("user_id"),
            PersonId = reader.GetInt32("person_id"),
            RoleId = reader.GetInt32("role_id"),
            Username = reader.GetString("username"),
            PasswordHash = reader.GetString("password_hash"),
            Email = reader.GetString("email"),
            IsActive = reader.GetBoolean("is_active"),
            LastLogin = reader.IsDBNull("last_login") ? null : reader.GetDateTime("last_login"),
            AccountCreated = reader.GetDateTime("account_created")
        };
    }
}
