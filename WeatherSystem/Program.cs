class Program
{
    static void Main(String[] args)
    {
        var dataFilePath = $@"C:\Users\Jana\source\repos\RealTimeWeatherService\Bot\BotConfiguration.json";
        var botConfigs = BotConfigurationLoader.LoadConfiguration(dataFilePath);

        var rainBot = new RainBot();
        var sunBot = new SunBot();
        var snowBot = new SnowBot();

        rainBot.Configure(botConfigs["RainBot"]);
        sunBot.Configure(botConfigs["SunBot"]);
        snowBot.Configure(botConfigs["SnowBot"]);

        var weatherSystem = new WeatherMonitoringSystem();
        weatherSystem.AddBot(rainBot);
        weatherSystem.AddBot(sunBot);
        weatherSystem.AddBot(snowBot);

        Console.WriteLine("Enter weather data (JSON or XML):");
        var input = Console.ReadLine();

        Console.WriteLine();

        IWeatherDataParser parser = input.TrimStart().StartsWith("{")
            ? (IWeatherDataParser)new JsonWeatherDataParser()
            : new XmlWeatherDataParser();

        var weatherData = parser.Parse(input);

        weatherSystem.NotifyBots(weatherData);
    }
}