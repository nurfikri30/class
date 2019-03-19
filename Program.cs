using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    public class Program

    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.Nim = "18.11.2338";
            saya.Nama = "Fikri";
            saya.Ipk = 40f;

            kamu.Nim = "18.11.2338";
            kamu.Nama = "Fikri";
            kamu.Ipk = 40f;

            saya.Registrasi();
            saya.Isikrs();

            kamu.Registrasi();
            kamu.Isikrs();

            Console.ReadKey();
        }
    }
}