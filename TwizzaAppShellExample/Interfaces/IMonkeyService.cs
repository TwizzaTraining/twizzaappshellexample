using TwizzaAppShellExample.Models;

namespace TwizzaAppShellExample.Interfaces
{
    public interface IMonkeyService
    {
        public Task<List<Monkey>> GetMonkeys();
    }
}
