using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            int symbol1 = int.Parse(Console.ReadLine());
            int symbol2 = int.Parse(Console.ReadLine());
            char symbol = Convert.ToChar(symbol1);
            char symboll= Convert.ToChar(symbol2);
            for (int i = symbol ; i <= symboll; i++)
            {
                c = (char)i;
                
                    Console.Write("{0} ",(char)i);
                
            }
            Console.WriteLine();

        }
    }
}
