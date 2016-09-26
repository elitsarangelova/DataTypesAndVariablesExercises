using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariblesInHexFormat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int convert = Convert.ToInt32(input, 16);
            Console.WriteLine(convert);
               


        }
    }
}
