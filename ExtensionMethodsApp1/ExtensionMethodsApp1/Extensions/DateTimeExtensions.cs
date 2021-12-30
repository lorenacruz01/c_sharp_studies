using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionMethodsApp1.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
                //return Convert.ToInt32(duration.TotalHours);
            } else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
                //return Convert.ToInt32(duration.TotalDays);
            }
        }

    }
}
