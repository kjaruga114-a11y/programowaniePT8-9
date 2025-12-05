using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacjaPogodowa
{
    internal  class Utils
    {
        internal  Weather ChangeWeather(Weather weather)
        {
            var objectToChange = new Weather();
            // objectToChange.Id = weather.Id;
            Console.WriteLine($"Weather measured by:{weather.MeasuredBy}");
            objectToChange.MeasuredBy = "Jan Kowalski";
            // weather.MeasurementDate = DateTime.Now;
            return objectToChange;
        }
    }
}
