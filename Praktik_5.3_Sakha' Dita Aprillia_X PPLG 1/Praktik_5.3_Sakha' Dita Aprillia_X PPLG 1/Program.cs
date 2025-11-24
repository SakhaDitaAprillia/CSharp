using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._3_Sakha__Dita_Aprillia_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUser = "";

            Console.WriteLine("Program akan terus berjalan hingga Anda mengetik 'keluar'.");

            while (inputUser.ToLower() != "keluar")
            {
                Console.WriteLine("\nKetik sesuatu (atau 'keluar' untuk berhenti): ");
                inputUser = Console.ReadLine();

                Console.WriteLine("Anda mengetik: " + inputUser);
            }
                Console.WriteLine("\nProgram selesai. Terimakasih!");
        }
    }
}
