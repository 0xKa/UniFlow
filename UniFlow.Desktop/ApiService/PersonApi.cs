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
    {
        return await _http.GetFromJsonAsync<List<PersonDTO>>("api/People") ?? new List<PersonDTO>();
    }

}
