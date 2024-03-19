using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalonUserApp.Class_Components
{
    internal class Appoint
    {
        public static string cName, cNumber, cAge,
            serviceID, serviceName, serviceAmount, serviceTypeID, serviceVariationID;
        public static DateTime appointDate;
        public static int ReferenceNumber;

        public static void SetUserInfo(string name, string number, string age)
        {
            cName = name;
            cNumber = number;
            cAge = age;
        }

        public static void SetServiceInfo(string sID, string sName, string sAmount, string sTypeID, string sVariationID)
        {
            serviceID = sID;
            serviceName = sName;
            serviceAmount = sAmount;
            serviceTypeID = sTypeID;
            serviceVariationID = sVariationID;
        }

        public static void SetAppointYearMonth(string month, string year)
        {
            // Parse the month name to its corresponding numerical value
            int monthValue = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

            int yearValue = int.Parse(year);

            // Set the appointDate's month and year
            appointDate = new DateTime(yearValue, monthValue, appointDate.Day);
        }

        public static void SetAppointDay(string day)
        {
            int dayValue = int.Parse(day);
            appointDate = appointDate.AddDays(dayValue - appointDate.Day);
        }

        public static void SetAppointHour(string hour)
        {
            // Parse the hour string
            string[] parts = hour.Split(':', ' '); // Split by colon and space
            int hourValue = int.Parse(parts[0]); // Extract hours
            int minuteValue = int.Parse(parts[1]); // Extract minutes
            string amPm = parts[2].ToLower(); // Extract am/pm/noon/midnight and convert to lowercase for case-insensitivity

            // Adjust hours for pm, noon, and midnight
            if (amPm == "pm" && hourValue != 12)
            {
                hourValue += 12;
            }
            else if (amPm == "noon")
            {
                hourValue = 12;
            }
            else if (amPm == "midnight")
            {
                hourValue = 0;
            }

            // Set the appointDate's hour and minute
            appointDate = appointDate.Date.AddHours(hourValue).AddMinutes(minuteValue);
        }

        public static int AppointNumber()
        {
            Random random = new Random();

            int number = random.Next(10000000, 99999999); // Generates a number between 10000000 and 99999999

            return number;
        }






    }
}
