using System;

namespace Projek_Akhir_Sakha__Dita_Aprillia
{
    internal class Program
    {
            // Deklarasi array global untuk menyimpan data siswa dan keterangannya
            static string[] namaSiswa = new string[100];
            static string[] keterangan = new string[100];
            static int jumlahData = 0; // Menyimpan jumlah data yang telah diinput

            static void Main(string[] args)
            {
                int pilihan;
                bool ulang = true; // Variabel kontrol untuk perulangan menu utama

                do
                {
                    // Struktur perulangan do-while agar menu tampil berulang kali
                    Console.Clear();
                    Console.WriteLine("=================================================================================================================================");
                    Console.WriteLine("==========                                   DAFTAR HADIR SISWA X PPLG 1                                               ==========");
                    Console.WriteLine("=================================================================================================================================");
                    Console.WriteLine("1. Tambah Data Kehadiran");
                    Console.WriteLine("2. Tampilkan Daftar Hadir");
                    Console.WriteLine("3. Hitung Statistik Kehadiran");
                    Console.WriteLine("4. Keluar");
                    Console.WriteLine("=================================================================================================================================");
                    Console.Write("Pilih menu (1-4): ");
                    pilihan = Convert.ToInt32(Console.ReadLine()); // Input pilihan menu dari user

                    // Percabangan switch untuk menjalankan fungsi sesuai pilihan
                    switch (pilihan)
                    {
                        case 1:
                            TambahData(); // Panggil fungsi untuk menambah data
                            break;
                        case 2:
                            TampilkanData(); // Panggil fungsi untuk menampilkan data
                            break;
                        case 3:
                            HitungStatistik(); // Panggil fungsi untuk menghitung statistik
                            break;
                        case 4:
                            ulang = false; // Mengakhiri program
                            Console.WriteLine("Terima kasih!");
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid!");
                            break;
                    }

                    // Menunggu pengguna menekan tombol sebelum kembali ke menu utama
                    if (ulang)
                    {
                        Console.Write("\nTekan Enter untuk kembali...");
                        Console.ReadKey();
                    }

                } while (ulang); // Pengulangan selama variabel ulang bernilai true
            }

            // Fungsi untuk menambah data kehadiran
            static void TambahData()
            {
                Console.Clear();
                Console.WriteLine("=== Tambah Data Kehadiran ===");
                Console.Write("Masukkan jumlah siswa yang akan ditambahkan: ");
                int jumlah = Convert.ToInt32(Console.ReadLine()); // Input jumlah siswa baru

                // Perulangan untuk menambah data beberapa siswa sekaligus
                for (int i = 0; i < jumlah; i++)
                {
                    Console.Write($"\nNama siswa ke-{jumlahData + 1}: ");
                    namaSiswa[jumlahData] = Console.ReadLine(); // Input nama siswa 

                    //Menampilkan pilihan keterangan kehadiran
                    Console.WriteLine("Pilih keterangan:");
                    Console.WriteLine("1. Hadir");
                    Console.WriteLine("2. Izin");
                    Console.WriteLine("3. Sakit");
                    Console.WriteLine("4. Alfa");
                    Console.Write("Pilihan: ");
                    int ket = Convert.ToInt32(Console.ReadLine());

                    // Percabangan if-else untuk menentukan keterangan sesuai pilihan user
                    if (ket == 1)
                    {
                        keterangan[jumlahData] = "Hadir";
                    }
                    else if (ket == 2)
                    {
                        keterangan[jumlahData] = "Izin";
                    }
                    else if (ket == 3)
                    {
                        keterangan[jumlahData] = "Sakit";
                    }
                    else if (ket == 4)
                    {
                        keterangan[jumlahData] = "Alfa";
                    }
                    else
                        keterangan[jumlahData] = "Tidak Diketahui";

                    jumlahData++; // Menambah jumlah data yang tersimpan
                }

                Console.WriteLine("\nData berhasil ditambahkan!");
            }

            // Fungsi untuk menampilkan data kehadiran
            static void TampilkanData()
            {
                Console.Clear();
                Console.WriteLine("======== Daftar Hadir Siswa X PPLG 1 ===========");

                // Cek apakah data sudah ada atau belum
                if (jumlahData == 0)
                {
                    Console.WriteLine("Belum ada data yang dimasukkan.");
                    return; // Keluar dari fungsi jika belum ada data
                }

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("No\tNama Siswa\tKeterangan");
                Console.WriteLine("------------------------------------------------");

                // Perulangan untuk menampilkan seluruh data siswa
                for (int i = 0; i < jumlahData; i++)
                {
                    Console.WriteLine($"{i + 1}\t{namaSiswa[i]}\t\t{keterangan[i]}");
                }

                Console.WriteLine("------------------------------------------------");
            }

            // Fungsi untuk menghitung statistik kehadiran
            static void HitungStatistik()
            {
                Console.Clear();
                Console.WriteLine("=== Statistik Kehadiran ===");

                int hadir = 0, izin = 0, sakit = 0, alfa = 0; // Variabel untuk menghitung jumlah masing - masing status

                // Perulangan untuk menghitung total masing - masing keterangan
                for (int i = 0; i < jumlahData; i++)
                {
                    switch (keterangan[i])
                    {
                        case "Hadir":
                            hadir++;
                            break;
                        case "Izin":
                            izin++;
                            break;
                        case "Sakit":
                            sakit++;
                            break;
                        case "Alfa":
                            alfa++;
                            break;
                    }
                }

                // Menampilkan hasil perhitungan
                Console.WriteLine($"Total Siswa: {jumlahData}");
                Console.WriteLine($"Hadir: {hadir}");
                Console.WriteLine($"Izin: {izin}");
                Console.WriteLine($"Sakit: {sakit}");
                Console.WriteLine($"Alfa: {alfa}");

                // Operator aritmetika digunakan untuk menghitung presentase kehadiran
                if (jumlahData > 0)
                {
                    double persenHadir = (double)hadir / jumlahData * 100;
                    Console.WriteLine($"\nPersentase Kehadiran: {persenHadir:F2}%");
                }
            }
        }
    }
