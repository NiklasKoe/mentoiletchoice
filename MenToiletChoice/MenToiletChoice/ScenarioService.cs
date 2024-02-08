using MenToiletChoice.DTOs;
using System.Text.Json;

namespace MenToiletChoice
{
    public static class ScenarioService
    {
        public static List<ScenarioDTO> GetConfig()
        {
            var file = File.ReadAllText("config.json");
            //
            var json = JsonSerializer.Deserialize<Config>(file);
            //
            if (json == null)
            {
                throw new Exception();
            }
            //
            return json.Scenarios;
        }
    }
}
