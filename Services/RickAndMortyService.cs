using RickAndMortyVisor.Models;
using System.Net.Http.Json;

namespace RickAndMortyVisor.Services;

public class RickAndMortyService
{
    private readonly HttpClient _http;

    public RickAndMortyService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<Character>> GetCharactersAsync()
    {
        var response = await _http.GetFromJsonAsync<ApiResponse>("https://rickandmortyapi.com/api/character");
        return response?.Results ?? new List<Character>();
    }

    private class ApiResponse
    {
        public List<Character> Results { get; set; }
    }
}
