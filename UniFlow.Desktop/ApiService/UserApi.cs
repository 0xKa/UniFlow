using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UniFlow.Shared;
using UniFlow.Shared.DTOs;

namespace UniFlow.Desktop.ApiService
{
    public class UserApi
    {
        private readonly HttpClient _http;

        public UserApi()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri(Global.BaseAddress),
                Timeout = TimeSpan.FromSeconds(5)
            };
        }

        // GET: api/Users
        public async Task<List<UserDTO>> GetAllAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<UserDTO>>("api/Users") ?? [];
            }
            catch
            {
                return [];
            }
        }

        // GET: api/Users/{id}
        public async Task<UserDTO?> GetByIdAsync(int id)
        {
            try
            {
                return await _http.GetFromJsonAsync<UserDTO>($"api/Users/{id}");
            }
            catch
            {
                return null;
            }
        }

        // GET: api/Users/username/{username}
        public async Task<UserDTO?> GetByUsernameAsync(string username)
        {
            try
            {
                return await _http.GetFromJsonAsync<UserDTO>($"api/Users/username/{username}");
            }
            catch
            {
                return null;
            }
        }

        // POST: api/Users
        public async Task<int?> AddAsync(UserDTO user)
        {
            try
            {
                var response = await _http.PostAsJsonAsync("api/Users", user);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<int>();
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        // PUT: api/Users/{id}
        public async Task<bool> UpdateAsync(int id, UserDTO user)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"api/Users/{id}", user);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        // PUT: api/Users/{id}/password
        public async Task<bool> UpdatePasswordAsync(int id, string passwordHash)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"api/Users/{id}/password", passwordHash);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        // PUT: api/Users/{id}/last-login
        public async Task<bool> UpdateLastLoginAsync(int id)
        {
            try
            {
                var response = await _http.PutAsync($"api/Users/{id}/last-login", null);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        // PUT: api/Users/{id}/status
        public async Task<bool> SetActiveStatusAsync(int id, bool isActive)
        {
            try
            {
                var response = await _http.PutAsJsonAsync($"api/Users/{id}/status", isActive);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        // DELETE: api/Users/{id}
        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var response = await _http.DeleteAsync($"api/Users/{id}");
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }

        // GET: api/Users/view
        public async Task<List<UserViewDTO>> GetAllFromViewAsync()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<UserViewDTO>>("api/Users/view") ?? [];
            }
            catch
            {
                return [];
            }
        }

        // GET: api/Users/view/{id}
        public async Task<UserViewDTO?> GetViewByIdAsync(int id)
        {
            try
            {
                return await _http.GetFromJsonAsync<UserViewDTO>($"api/Users/view/{id}");
            }
            catch
            {
                return null;
            }
        }

        // GET: api/Users/view/username/{username}
        public async Task<UserViewDTO?> GetViewByUsernameAsync(string username)
        {
            try
            {
                return await _http.GetFromJsonAsync<UserViewDTO>($"api/Users/view/username/{username}");
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            _http?.Dispose();
        }
    }
}