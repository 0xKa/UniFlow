using System.Net.Http.Json;
using UniFlow.DTOs;

namespace UniFlow.Desktop.ApiService;

public class PersonApi
{
    private readonly HttpClient _http;


    public PersonApi()
    {
        _http = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7290/")
        };


    }

    public async Task<List<PersonDTO>> GetAllAsync()
        => await _http.GetFromJsonAsync<List<PersonDTO>>("api/People") ?? new List<PersonDTO>();

    public async Task<PersonDTO?> GetByIdAsync(int id)
            => await _http.GetFromJsonAsync<PersonDTO>($"api/People/{id}");

    public async Task<PersonDTO?> AddAsync(PersonDTO person)
    {
        var response = await _http.PostAsJsonAsync("api/People", person);
        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<PersonDTO>();
        }
        return null;
    }

    public async Task<bool> UpdateAsync(int id, PersonDTO person)
    {
        var response = await _http.PutAsJsonAsync($"api/People/{id}", person);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _http.DeleteAsync($"api/People/{id}");
        return response.IsSuccessStatusCode;
    }

}
