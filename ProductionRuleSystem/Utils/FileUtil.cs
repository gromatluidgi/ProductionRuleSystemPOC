using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProductionRuleSystem.Utils
{
    public static class FileUtil
    {
        public static T? ReadJsonFromFile<T>(string filepath)
        {
            string json = string.Empty;
            try
            {
                using (StreamReader read = new StreamReader(filepath))
                {
                    json = read.ReadToEnd();
                }
                return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.Never,
                });
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}
