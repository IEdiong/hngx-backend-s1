using System.Text.Json;

namespace HngX.StageOne.Utils
{
    public class SnakeCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            // Convert the name to snake_case
            return string.Concat(name.Select((x, i) =>
            i > 0 && char.IsUpper(x)
                ? "_" + x.ToString()
                : x.ToString())).ToLower();
        }
    }
}