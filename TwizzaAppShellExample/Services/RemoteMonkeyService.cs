using System.Net.Http.Json;
using TwizzaAppShellExample.Interfaces;
using TwizzaAppShellExample.Models;

namespace TwizzaAppShellExample.Services
{
    public class RemoteMonkeyService : IMonkeyService
    {

        private HttpClient _httpClient;
        private List<Monkey> _monkeyList = new();
        public RemoteMonkeyService()
        {
            this._httpClient = new HttpClient();
        }
        public async Task<List<Monkey>> GetMonkeys()
        {
            if (_monkeyList?.Count > 0)
                return _monkeyList;

            var response = await _httpClient.GetAsync("https://www.montemagno.com/monkeys.json");

            if (response.IsSuccessStatusCode)
            {
                _monkeyList = await response.Content.ReadFromJsonAsync(MonkeyContext.Default.ListMonkey);
            }

            return _monkeyList;
        }

    }
}