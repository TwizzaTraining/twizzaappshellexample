using System.Text.Json.Serialization;

namespace TwizzaAppShellExample.Models
{
    [JsonSerializable(typeof(List<Monkey>))]
    internal sealed partial class MonkeyContext : JsonSerializerContext
    {

    }
}
