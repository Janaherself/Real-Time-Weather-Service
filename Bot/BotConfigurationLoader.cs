using System.Text.Json;

public class BotConfigurationLoader
{
    public static Dictionary<string, Bot> LoadConfiguration(string filePath)
    {
        var configJson = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<Dictionary<string, Bot>>(configJson);
    }
}