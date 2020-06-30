using System;
using System.Collections.Generic;
using System.Threading;
using tugas_lab_9.Class_Obj;

namespace tugas_lab_9
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // deklarasi list karyawan
            List<Karyawan> karyawan = new List<Karyawan>();

            // Default data karyawan
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "2774";
            karyawanTetap.Nama = "lilis";
            karyawanTetap.GajiBulanan = 10000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "2809";
            karyawanHarian.Nama = "M Arifin";
            karyawanHarian.UpahPerJam = 60000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "4727";
            sales.Nama = "lilis";
            sales.JumlahPenjualan = 15;
            sales.Komisi = 80000;

            karyawan.Add(karyawanTetap);
            karyawan.Add(karyawanHarian);
            karyawan.Add(sales);

            Menu(karyawan);
        }

        static void Menu(List<Karyawan> karyawan)
        {
            bool status = true;

            do
            {
                // clear console
                Console.Clear();

                // menampilkan selamat datang dan menu aplikasi
                Console.WriteLine("=====================================");
                Console.WriteLine("========== SELAMAT DATANG ===========");
                Console.WriteLine("=====================================");

                Console.WriteLine("");

                Console.WriteLine("Silahkan Pilih Menu Aplikasi: ");
                Console.WriteLine("1. Tambah Data\n2. Hapus Data \n3. Tampilkan Data \n4. Tentang Aplikasi \n5. Keluar");

                Console.WriteLine("");

                // input pilihan
                InvalidOption:
                string opt;
                Console.Write("Masukkan Pilihan [1-5]: ");
                opt = Console.ReadLine();


                if (opt == "1")
                {
                    // exec function tambahdata()
                    TambahData(karyawan);
                    BalikMenu();
                }
                else if (opt == "2")
                {
                    // exec function hapusdata()
                    HapusData(karyawan);
                    BalikMenu();
                }
                else if (opt == "3")
                {
                    // exec function tampilkandata()
                    TampilkanData(karyawan);
                    BalikMenu();
                }
                else if (opt == "4")
                {
                    AboutApp();
                }
                else if (opt == "5")
                {
                    // hanlde jika pilihan bernilai 5 / keluar
                    Console.WriteLine("Terima Kasih telah menggunakan program ini :)");
                    Thread.Sleep(2000);
                    status = false;
                }
                else
                {
                    // handle data jika inputan tidak valid
                    Console.WriteLine("Pilihan tidak ada, silahkan masukkan lagi");
                    goto InvalidOption;
                }
               
            } while (status);
        }

        static void TambahData(List<Karyawan> karyawan)
        {
            // menghapus / clear console
            Console.Clear();

            // menampilkan jenis karyawan
            Console.WriteLine("=====================================");
            Console.WriteLine("========== TAMBAH KARYAWAN ==========");
            Console.WriteLine("=====================================");
            Console.WriteLine("\nSilahkan Pilih Jenis Karyawan: ");
            Console.WriteLine("1. Karyawan Tetap \n2. Karyawan Harian \n3. Sales");

            // input pilihan tambah karyawan
            InvalidOption:
            string opt;
            Console.Write("Masukkan Pilihan [1-3]: ");
            opt = Console.ReadLine();

            Console.WriteLine();

            if (opt == "1")
            {

                // membuat instance dari class KaryawanTetap
                KaryawanTetap karyawanTetap = new KaryawanTetap();


                Console.WriteLine("Tambah Karyawan Tetap");

                // Input Data ke instance Karyawantetap
                Console.Write("Masukkan NIK \t\t: ");
                karyawanTetap.NIK = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                karyawanTetap.Nama = Console.ReadLine();

                Console.Write("Masukkan Gaji Bulanan \t: ");
                karyawanTetap.GajiBulanan = Convert.ToDouble(Console.ReadLine());

                // Menambahkan Data
                karyawan.Add(karyawanTetap);

            }
            else if (opt == "2")
            {
                // Membuat instance dari class KaryawanHarian()
                KaryawanHarian karyawanHarian = new KaryawanHarian();


                Console.WriteLine("Tambah Karyawan Harian");

                // Input data ke instance karyawanHarian
                Console.Write("Masukkan NIK \t\t: ");
                karyawanHarian.NIK = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                karyawanHarian.Nama = Console.ReadLine();

                Console.Write("Masukkan Upah per Jam \t: ");
                karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Jam Kerja \t: ");
                karyawanHarian.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());

                // Menambah data ke list karyawan
                karyawan.Add(karyawanHarian);

            }
            else if (opt == "3")
            {
                // Membuat Instance dari class SAles
                Sales sales = new Sales();

                Console.WriteLine("Tambah Karyawan Harian");

                // Input data ke Instance sales
                Console.Write("Masukkan NIK \t\t: ");
                sales.NIK = Console.ReadLine();

                Console.Write("Masukkan Nama \t\t: ");
                sales.Nama = Console.ReadLine();

                Console.Write("Masukkan Jml Penjualan \t: ");
                sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());

                Console.Write("Masukkan Komisi \t: ");
                sales.Komisi = Convert.ToDouble(Console.ReadLine());

                // menambah data ke list karyawan
                karyawan.Add(sales);
            }
            else
            {
                // Handle jika inputan tidak valid
                Console.WriteLine("Pilihan tidak ada, silahkan masukkan lagi");
                goto InvalidOption;
            }
        }

        static void HapusData(List<Karyawan> karyawan)
        {
            // clear console
            Console.Clear();

            // menampilkan selamat datang dan menu aplikasi
            Console.WriteLine("=====================================");
            Console.WriteLine("======== HAPUS DATA KARYAWAN ========");
            Console.WriteLine("=====================================");

            // insiailasi variable found
            bool found = true;

            // input nik
            string nik;
            Console.Write("\nMasukkan NIK Karyawan: ");
            nik = Console.ReadLine();

            // looping data karyawan
            for (int i = 0; i < karyawan.Count; i++)
            {
                // seleksi jika inputan nik sama dengan pada nik di list  karyawan
                if (karyawan[i].NIK == nik)
                {
                    // data jika ditemukan
                    karyawan.Remove(karyawan[i]);
                    found = true;
                    break;
                } else
                {
                    // data jika tdk ditemukan
                    found = false;
                }
            }

            if (!found)
            {
                Console.WriteLine("Data tidak dengan NIK = {0} tidak ditemukan", nik);
            } else
            {
                Console.WriteLine("Data dengan NIK = {0} berhasil dihapus", nik);
            }
        }

        static void TampilkanData(List<Karyawan> karyawan)
        {

            // menghapus / clear console
            Console.Clear();

            // menampilkan data
            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji\t\t |");
            Console.WriteLine("==================================================");
            for (int i = 0; i < karyawan.Count; i++)
            {

                Console.WriteLine(" {0}. | {1} {2} \t\t | {3} \t |", i + 1, karyawan[i].NIK, karyawan[i].Nama, karyawan[i].Gaji());
            }


        }

        static void AboutApp()
        {
            // clear console
            Console.Clear();

            // menampilkan about app
            Console.WriteLine("=====================================");
            Console.WriteLine("============ ABOUT APP ==============");
            Console.WriteLine("=====================================");

            Console.WriteLine("\nNama     : Lilis Widiyanti");
            Console.WriteLine("NIM      : 19.11.2774");
            Console.WriteLine("Kelas    : 19 IF 03");

            Console.WriteLine("\n* Dibuat dengan segenap hati dan jiwa raga. Happy Coding!! :)");
            Console.WriteLine("* https://github.com/lilis370");

            BalikMenu();
        }

        static void BalikMenu()
        {
            // Funtion untuk balik ke menu awal
            Console.WriteLine("\nTekan sembarang untuk kembali ke menu awal");
            Console.ReadKey();
        }
    }
}