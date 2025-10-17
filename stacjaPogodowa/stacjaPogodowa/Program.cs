// See https://aka.ms/new-console-template for more information
using stacjaPogodowa;

Console.WriteLine("Hello, World!");

Console.ReadKey();

var weather2 = new Weather();
var weather5 = new Weather();

var utils = new Utils();

weather5 = utils.ChangeWeather(weather2);
