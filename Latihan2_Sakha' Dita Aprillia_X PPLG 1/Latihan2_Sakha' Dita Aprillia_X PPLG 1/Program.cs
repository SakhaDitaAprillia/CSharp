using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan2_Sakha__Dita_Aprillia_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int total = 0;

            while (i <= 5)
            {
                total += i;
                i++;
            }

            Console.WriteLine("Total: " + total);
        }
    }
}
