public class WeatherMonitoringSystem
{
    private List<IWeatherBot> _bots = new List<IWeatherBot>();

    public void AddBot(IWeatherBot bot)
    {
        _bots.Add(bot);
    }

    public void NotifyBots(WeatherData data)
    {
        foreach (var bot in _bots)
        {
            bot.Update(data);
        }
    }
}