using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__Polymorphsim__Abstraction___Collection_2695
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap     = new KaryawanTetap();
            karyawanTetap.Nik               = "19.11.2695";
            karyawanTetap.Nama              = "Novanda ary praditya";
            karyawanTetap.GajiBulanan       = 6000000;

            KaryawanHarian karyawanHarian   = new KaryawanHarian();
            karyawanHarian.Nik              = "19.11.9999";
            karyawanHarian.Nama             = "Novanda";
            karyawanHarian.JumlahJamKerja   = 6;
            karyawanHarian.UpahPerJam       = 10000;

            Sales sales                     = new Sales();
            sales.Nik                       = "19.11.9998";
            sales.Nama                      = "Ary";
            sales.JumlahPenjualan           = 20;
            sales.Komisi                    = 50000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
