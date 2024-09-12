public class RainBot : IWeatherBot
{
    private Bot? _bot;

    public void Configure(Bot bot)
    {
        _bot = bot;
    }

    public void Update(WeatherData data)
    {
        if (_bot.enabled && data.Humidity > _bot.humidityThreshold)
        {
            Console.WriteLine("RainBot activated!");
            Console.WriteLine($"RainBot: {_bot.message}\n");
        }
    }
}