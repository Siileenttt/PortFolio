using System.Net.Http.Json;
using Portfolio.Models;

namespace Portfolio.Services;

public class PortfolioService
{
    private readonly HttpClient _http;
    private PortfolioData? _cache;

    public PortfolioService(HttpClient http) => _http = http;

    public async Task<PortfolioData> GetAsync()
    {
        if (_cache is not null) return _cache;

        // Relative path: works at "/" and under a sub-path like "/my-repo/".
        _cache = await _http.GetFromJsonAsync<PortfolioData>("data/portfolio.json")
                 ?? throw new InvalidOperationException("portfolio.json is empty.");
        return _cache;
    }
}
