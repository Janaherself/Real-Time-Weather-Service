public class SnowBot : IWeatherBot
{
    private Bot _bot;

    public void Configure(Bot bot)
    {
        _bot = bot;
    }

    public void Update(WeatherData data)
    {
        if (_bot.enabled && data.Temperature < _bot.temperatureThreshold)
        {
            Console.WriteLine("SnowBot activated!");
            Console.WriteLine($"SnowBot: {_bot.message}\n");
        }
    }
}