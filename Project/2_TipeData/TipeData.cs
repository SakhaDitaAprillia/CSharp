namespace TipeData;

public class TipeData
{
    //Praktik2.1- Variabel bilangan bulat dan teks
    public static void Praktik1()
    {
        int umur = 17;
        string nama = "Faizal";

        Console.WriteLine("Nama: " + nama);
        Console.WriteLine("Umur: " + umur);
    }

    //Praktik2.2- Variabel desimal dan karakter
    public static void Praktik2()
    {
        double tinggi = 172.6;
        char jeniskelamin = 'L';

        Console.WriteLine("Tinggi Badan: " + tinggi);
        Console.WriteLine("Jenis Kelamin: " + jeniskelamin);
    }

    //Praktik2.3- Variabel logika (boolean)
    public static void Praktik3()
    {
        bool isPelajar = true;
        string sekolah = "SMK NEGERI 1 KANDEMAN";

        Console.WriteLine("Apakah masih pelajar? " + isPelajar);
        Console.WriteLine("Sekolah: " + sekolah);
    }

    //Praktik2.4- Variabel dengan tipe data yang bervariasi
    public static void Praktik4()
    {
        // Deklarasi variabel
        int umur = 17;
        double nilai = 90.5;
        char grade = 'A';
        string nama = "Faizal";
        bool lulus = true;

        // Menampilkan nilai variabel
        Console.WriteLine("Nama Siswa   : " + nama);
        Console.WriteLine("Umur         : " + umur);
        Console.WriteLine("Nilai        : " + nilai);
        Console.WriteLine("Grade        : " + grade);
        Console.WriteLine("Status Lulus : " + lulus);

        Console.ReadKey(); // Menunggu input tombol sebelum keluar 
    }
}