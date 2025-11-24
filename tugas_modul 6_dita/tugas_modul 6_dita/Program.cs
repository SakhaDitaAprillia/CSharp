using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_modul_6_dita
{
    internal class Program
    {
        static void Main()
        {
            string[,] siswa = new string[3, 3]
            {
                { "Andi", "L", "X IPA 1" },
                { "Bunga", "P", "X IPS 2" },
                { "Cahyo", "L", "XI IPA 3" }
            };

            Console.WriteLine("Data Siswa: ");
            Console.WriteLine("Nama\tJenis Kelamin\tKelas");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{siswa[i, 0]}\t{siswa[i, 1]}\t\t{siswa[i, 2]}");
            }
        }
    }
}
