using System.Net.Http.Json;
using System.Text.Json;
using TwizzaAppShellExample.Interfaces;
using TwizzaAppShellExample.Models;

namespace TwizzaAppShellExample.Services
{
    public class LocalMonkeyService : IMonkeyService
    {

        private HttpClient _httpClient;
        private List<Monkey> _monkeyList = new();
        public LocalMonkeyService()
        {
            this._httpClient = new HttpClient();
        }
        public async Task<List<Monkey>> GetMonkeys()
        {
            if (_monkeyList?.Count > 0)
                return _monkeyList;

            using var stream = await FileSystem.OpenAppPackageFileAsync("monkeys.json");
            using var reader = new StreamReader(stream);

            var contents = await reader.ReadToEndAsync();
            _monkeyList = JsonSerializer.Deserialize(contents, MonkeyContext.Default.ListMonkey);

            return _monkeyList;
        }

    }
}