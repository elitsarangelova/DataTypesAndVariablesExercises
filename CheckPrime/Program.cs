using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int check = 2; check <= input; check++)
            {
                bool isTrue = true;
                for (int divided = 2; divided <= Math.Sqrt(check); divided++)
                {
                    if (check%divided==0)
                    {
                        isTrue = false;
                        break;
                    }

                }
                Console.WriteLine("{0} -> {1}", check, isTrue);
            }
            
        }
    }
}
