using System.Xml.Linq;

public class XmlWeatherDataParser : IWeatherDataParser
{
    public WeatherData Parse(string input)
    {
        var xml = XElement.Parse(input);
        return new WeatherData
        {
            Location = xml.Element("Location")?.Value,
            Temperature = int.Parse(xml.Element("Temperature").Value),
            Humidity = int.Parse(xml.Element("Humidity").Value)
        };
    }
}