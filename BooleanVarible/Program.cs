using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVarible
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(input);
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
           
            
        }
    }
}
