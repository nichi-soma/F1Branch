using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying Tokyo Standard Time
            //Console.WriteLine(" Current time in Tokyo is : " + JstNow().ToString());
            

            // Random sample 
            Random cRandom = new System.Random();            
            var randomValue = cRandom.Next(999999).ToString();
            Console.WriteLine("Random Value : " + randomValue);

            Console.WriteLine("test for uploading to feature branch");

            Console.WriteLine("test for uploading second time to feature branch");

            Console.Read();
        }
        private static DateTime JstNow()
        {
            var tokyoTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.Now.ToUniversalTime(), tokyoTimeZone);
        }
    }
}
