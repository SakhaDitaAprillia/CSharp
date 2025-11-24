using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_modul_7_dita
{
    internal class Program
    {
        static void Kali(int a, int b, int c)
        {
            int hasil = a * b * c;
            Console.WriteLine("Hasil perkalian: " + hasil);
        }
        static double RataRata(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
        static double KonversiSuhu(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        static void Main(string[] args)
        {
            Kali(2, 3, 4);

            double rata = RataRata(70, 80, 90);
            Console.WriteLine("Rata-rata: " + rata);

            double suhuCelcius = 25;
            double suhuFarenheit = KonversiSuhu(suhuCelcius);
            Console.WriteLine($"{suhuCelcius}℃ = {suhuFarenheit}℉");
        }
    }
}
