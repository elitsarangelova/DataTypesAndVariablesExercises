using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long overAllFilterTime =(long) (pictures * filterTime);
            long filterPictuares = (long)Math.Ceiling((double)(pictures * filterFactor / 100));
            long overAllUploadTime = filterPictuares * uploadTime;

            long time = overAllUploadTime + overAllFilterTime;
            TimeSpan timeSpan = TimeSpan.FromSeconds(time);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
            timeSpan.Days,
            timeSpan.Hours,
            timeSpan.Minutes,
            timeSpan.Seconds);

        }
    }
}
