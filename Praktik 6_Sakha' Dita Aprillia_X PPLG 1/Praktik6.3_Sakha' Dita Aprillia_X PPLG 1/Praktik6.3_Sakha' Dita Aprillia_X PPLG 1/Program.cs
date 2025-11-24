using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik6._3_Sakha__Dita_Aprillia_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[3];
            int[] nilai = new int[3];

            Console.Write("Masukkan nama siswa ke-1: ");
            nama[0] = Console.ReadLine();
            Console.Write("Masukkan nilai ke-1: ");
            nilai[0] = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nama siswa ke-2: ");
            nama[1] = Console.ReadLine();
            Console.Write("Masukkan siswa ke-2: ");
            nilai[1] = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nama siswa ke-3: ");
            nama[2] = Console.ReadLine();
            Console.Write("Masukkan nilai siswa ke-3: ");
            nilai[2] = int.Parse(Console.ReadLine());
        }
    }
}
