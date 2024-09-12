public class SunBot : IWeatherBot
{
    private Bot _bot;

    public void Configure(Bot bot)
    {
        _bot = bot;
    }

    public void Update(WeatherData data)
    {
        if (_bot.enabled && data.Temperature > _bot.temperatureThreshold)
        {
            Console.WriteLine("SunBot activated!");
            Console.WriteLine($"SunBot: {_bot.message}\n");
        }
    }
}