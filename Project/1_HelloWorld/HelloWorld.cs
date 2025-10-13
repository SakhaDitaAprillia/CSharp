namespace HelloWorld;

public class HelloWorld
{
    //Praktik 1.1 – menuliskan kode pertama kali di editor visual studio.
    public static void Praktik1()
    {
        Console.WriteLine("Hallo Dunia");
        Console.WriteLine("Nama saya Dita");
        Console.WriteLine("Saya belajar bahasa C #");
    }

    //Praktik1.2- Fungsi Output pada C# menggunakan fungsi WriteLine()
    public static void Praktik2()
    {
        Console.WriteLine("Selamat Datang di Pemrograman C#");
        Console.WriteLine("Ini adalah tutorial belajar C# dari dasar");
        Console.WriteLine("Terima kasih sudah menggunakan program ini");
    }

    //Praktik1.3- Perbedaan WriteLine() dengan Write()
    public static void Praktik3()
    {
        Console.WriteLine("=== BIODATA SAYA ===");
        Console.WriteLine("Nama: ");
        Console.WriteLine("Dita");
        Console.WriteLine("Alamat: Jepang");
    }

    //Praktik1.4- Fungsi Input pada C
    public static void Praktik4()
    {
        Console.WriteLine("=== PROGRAM INPUT NAMA ===");
        Console.WriteLine("Tuliskan nama kamu: ");
        string nama = Console.ReadLine() + " ";
        Console.WriteLine("Hi, {0} selamat datang!", nama);
    }

    //Praktik1.5- penggunaan input dan output C#
    public static void Praktik5()
    {
        Console.WriteLine("=== INPUT BIODATA SISWA ===");
        Console.Write("NAMA SISWA    : ");
        string nama = Console.ReadLine() + " ";
        Console.Write("KELAS         : ");
        string kelas = Console.ReadLine() + " ";
        Console.Write("JENIS KELAMIN : ");
        string jk = Console.ReadLine() + " ";
        Console.Write("JURUSAN       : ");
        string jur = Console.ReadLine() + " ";
        Console.WriteLine("======================");
        Console.WriteLine("=== BIODATA SISWA ===");
        Console.WriteLine($"Nama Siswa    : {nama}:");
        Console.WriteLine($"Kelas         : {kelas}");
        Console.WriteLine($"Jenis Kelamin : {jk}");
        Console.WriteLine($"Jurusan       : {jur}");
        Console.WriteLine("======================");
    }

    //Tugas1.1- Buatlah kode program untuk menampilkan biodata kalian masing-masing
    public static void Tugas1()
    {
        Console.WriteLine("=== INPUT BIODATA SISWA ===");
        Console.Write("NAMA LENGKAP         : ");
        string nama = Console.ReadLine() + " ";
        Console.Write("NAMA PANGGILAN       : ");
        string np = Console.ReadLine() + " ";
        Console.Write("JENIS KELAMIN        : ");
        string jk = Console.ReadLine() + " ";
        Console.Write("AGAMA                : ");
        string agm = Console.ReadLine() + " ";
        Console.Write("UMUR                 : ");
        string umr = Console.ReadLine() + " ";
        Console.Write("KELAS                : ");
        string kls = Console.ReadLine() + " ";
        Console.Write("JURUSAN              : ");
        string jur = Console.ReadLine() + " ";
        Console.Write("ALAMAT               : ");
        string almt = Console.ReadLine() + " ";
        Console.Write("HOBI                 : ");
        string hb = Console.ReadLine() + " ";
        Console.Write("CITA CITA            : ");
        string cc = Console.ReadLine() + " ";
        Console.WriteLine("===========================");
        Console.WriteLine("=== BIODATA SISWA ===");
        Console.WriteLine($"Nama Lengkap     : {nama} ");
        Console.WriteLine($"Nama Panggilan   : {np}   ");
        Console.WriteLine($"Jenis Kelamin    : {jk}   ");
        Console.WriteLine($"Agama            : {agm}  ");
        Console.WriteLine($"Umur             : {umr}  ");
        Console.WriteLine($"Kelas            : {kls}  ");
        Console.WriteLine($"Jurusan          : {jur}  ");
        Console.WriteLine($"Alamat           : {almt} ");
        Console.WriteLine($"Hobi             : {hb}   ");
        Console.WriteLine($"Cita Cita        : {cc}   ");
        Console.WriteLine("===========================");
    }
}