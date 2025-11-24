using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_5._8_Sakha__Dita_Aprillia_X_PPLG_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ulangiPilihan;

            do
             {
              Console.WriteLine("------------------------------------");
              Console.Write("Masukkan nama Anda: ");
              string nama = Console.ReadLine();
              Console.WriteLine($"Halo, {nama}! Proses telah selesai.");

              Console.Write("Apakah Anda ingin mengulangi lagi? (ya/tidak): ");
              ulangiPilihan = Console.ReadLine().ToLower();

              Console.WriteLine();

              } while (ulangiPilihan == "ya");
                Console.WriteLine("Terimakasih. Program selesai.");

        }
    }
}
