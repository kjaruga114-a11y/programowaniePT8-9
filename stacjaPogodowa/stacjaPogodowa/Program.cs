// See https://aka.ms/new-console-template for more information
using stacjaPogodowa;

Console.WriteLine("Hello, World!");

Console.ReadKey();

var weather2 = new Weather();
var weather5 = new Weather();

weather5 = ChangeWeather(weather2);
 Weather ChangeWeather(Weather weather)
{
    var objectToChange = new Weather();
   // objectToChange.Id = weather.Id;
    Console.WriteLine($"Weather measured by:{weather.MeasuredBy}");
    objectToChange.MeasuredBy = "Jan Kowalski";
   // weather.MeasurementDate = DateTime.Now;
    return objectToChange;
}