using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float distanceInKm = distanceInMeters / 1000;
            float metersPerSeconds = (distanceInMeters / seconds);
            float kilometersPerHours = distanceInKm / hours;
            float milesPerHours = distanceInMeters / 1609;
            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHours);
            Console.WriteLine(milesPerHours);
        }
    }
}
