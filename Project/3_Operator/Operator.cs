namespace Operator;

public class Operator
{
    //Praktik3.1- Operator Penjumlahan
    public static void Praktik1()
    {
        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil penjumlahan: " + (a + b));

        Console.Write("Masukkan angka ketiga: ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Masukkan angka keempat: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hasil penjumlahan (double): " + (c + d));
    }

    //Praktik3.2- Operator Pengurangan
    public static void Praktik2()
    {
        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil pengurangan: " + (a - b));

        Console.Write("Masukkan angka ketiga: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan angka keempat: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil pengurangan (double): " + (c - d));
    }

    //Praktik3.3- Operator Perkalian
    public static void Praktik3()
    {
        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil perkalian: " + (a * b));

        Console.Write("Masukkan angka ketiga: ");
        double c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan anngka keempat: ");
        double d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil perkalian (double): " + (c * d));
    }

    //Praktik3.4- Operator Pembagian
    public static void Praktik4()
    {
        Console.WriteLine("Masukkan angka pertama : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hasil pembagian : " + (a / b));

        Console.WriteLine("Masukkan angka ketiga : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan angka keempat : ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Hasil pembagian (double): " + (c / d));
    }

    //Praktik3.5- Operator Sisabagi
    public static void Praktik5()
    {
        Console.WriteLine("Masukkan angka pertama : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukkan angka kedua : ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sisa bagi : " + (a % b));

        Console.WriteLine("Masukkan angka ketiga : ");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Masukkan angka keempat : ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Sisa bagi : " + (c % d));
    }

    //Praktik3.6- Operator matematika penjumlahan beruntun
    public static void Praktik6()
    {
        Console.WriteLine("Masukkan angka : ");
        int x = Convert.ToInt32(Console.ReadLine());
        x++;
        Console.WriteLine("Setelah x++ : " + x);

        Console.WriteLine("Masukkan angka lain: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nilai awal : " + y);
        Console.WriteLine("Setelah ++y : " + (++y));
    }

    //Praktik3.7- Operator matematika pengurangan beruntun
    public static void Praktik7()
    {
        Console.WriteLine("Masukkan angka: ");
        int x = Convert.ToInt32(Console.ReadLine());
        x--;
        Console.WriteLine("Setelah x--: " + x);

        Console.WriteLine("Masukkan angka lain: ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nilai awal: " + y);
        Console.WriteLine("Nilai --y: " + (--y));
    }

    //Praktik3.8- Operator Perbandingan
    public static void Praktik8()
    {
        Console.WriteLine("=== Program Operator Perbandingan ===");

        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{a} > {b}   : " + (a > b));
        Console.WriteLine($"{a} < {b}   : " + (a < b));
        Console.WriteLine($"{a} >= {b}  : " + (a >= b));
        Console.WriteLine($"{a} <= {b}  : " + (a <= b));
        Console.WriteLine($"{a} == {b}  : " + (a == b));
        Console.WriteLine($"{a} != {b}  : " + (a != b));
    }

    //Praktik3.9- Operator Logika
    public static void Praktik9()
    {
        Console.WriteLine("=== Program Operator Logika ===");

        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nHasil Logika:");

        // AND 
        Console.WriteLine($"({a} > 5 && {b} < 10 : " + (a > 5 && b < 10));

        // OR
        Console.WriteLine($"({a} > 5 || {b} < 10 : " + (a > 5 || b < 10));

        // NOT
        Console.WriteLine($"!({a} > {b} : " + (!(a > b)));
    }

    //Praktik3.10- Operator Penugasan
    public static void Praktik10()
    {
        Console.WriteLine("=== Program Operasi Penugasan ===");
        Console.WriteLine("Masukkan nilai awal x : ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nHasil Operasi penugasan");
        Console.WriteLine("Nilai awal x = " + x);

        x += 5;
        Console.WriteLine("x += 5 → " + x);

        x -= 2;
        Console.WriteLine("x -= 2 → " + x);

        x *= 3;
        Console.WriteLine("x *= 3 → " + x);

        x /= 4;
        Console.WriteLine("x /= 4 → " + x);

        x %= 3;
        Console.WriteLine("x %= 3 → " + x);
    }

    //Tugas3.1- Buat program C# operator matematika : penjumlahan, pengurangan, perkalian, pembagian tiga buah bilangan.
    public static void Tugas1()
    {
        Console.WriteLine("=== Program Operator Matematika ===");

        Console.Write("Masukkan angka pertama: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan angka kedua: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukkan angka ketiga: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("==================================");

        Console.WriteLine("Hasil penjumlahan: " + (a + b + c));
        Console.WriteLine("Hasil pengurangan: " + (a - b - c));
        Console.WriteLine("Hasil perkalian: " + (a * b * c));
        Console.WriteLine("Hasil pembagian: " + (a / b / c));
    }

    //Tugas3.2- Buat program untuk memasukkan nilai siswa.
    public static void Tugas2()
    {
        Console.WriteLine("=== Program Memasukkan Nilai Siswa ===");

        Console.Write("Nama Siswa: ");
        string nama = Console.ReadLine() + " ";
        Console.WriteLine("Kelas: ");
        string kelas = Console.ReadLine() + " ";

        Console.Write("Nilai Matematika: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nilai Bahasa Indonesia: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nilai Bahasa Inggris: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int rata_rata = (a + b + c) / 3;
        Console.WriteLine("Nilai Rata rata      : " + rata_rata);

        Console.WriteLine("=====================================");

        Console.WriteLine("Nama Siswa              : " + nama);
        Console.WriteLine("Kelas                   : " + kelas);
        Console.WriteLine("Nilai Matematika        : " + a);
        Console.WriteLine("Nilai Bahasa Indonesia  : " + b);
        Console.WriteLine("Nilai Bahasa Inggris    : " + c);
        Console.WriteLine("Nilai Rata rata         : " + rata_rata);
    }

    //Latihan1- 1. Buatlah program untuk mengubah / konversi suhu dari Celcius ke fahrenheit dan reamur.
    public static void Latihan1()
    {
        Console.WriteLine("Masukkan suhu dalam celcius: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double f = (c * 9 / 5) + 32;
        double r = c * 4 / 5;

        Console.WriteLine("\n --- Hasil Konversi ---");
        Console.WriteLine("Celcius   : " + c + " °c ");
        Console.WriteLine("Farenheit : " + f + " °f ");
        Console.WriteLine("Reamur    : " + r + " °r");
    }

    //Latihan2- Buatlah program untuk mengkonversi nilai tukar Rupiah ke mata uang :
    //Dolar Amerika (USD)
    //Poundsterling Inggris (GBP)
    //Yen Jepang (JPY)
    //Riyal Saudi (SAR)
    public static void Latihan2()
    {
        Console.WriteLine("=== PROGRAM UNTUK MENGKONVERSI MATA UANG ===");

        Console.Write("Masukkan mata uang rupiah = ");
        int r = Convert.ToInt32(Console.ReadLine());
        int KursUSD = 16_635;
        int KursGBP = (int)22_223.80;
        int KursJPY = 112_31;
        int KursSAR = (int)4_416.86;

        double usd = r / KursUSD;
        double gbp = r / KursGBP;
        double jpy = r / KursJPY;
        double sar = r / KursSAR;

        Console.WriteLine("============================================");
        Console.WriteLine("Mata Uang Rupiah         = " + "Rp" + r);
        Console.WriteLine("Ke Dolar USD             = " + "$" + usd);
        Console.WriteLine("Ke Poundsterling Inggris = " + "₤" + gbp);
        Console.WriteLine("Ke Yen Jepang            = " + "¥" + jpy);
        Console.WriteLine("Ke Riyal Saudi           = " + "?.?" + sar);
    }
}