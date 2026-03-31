using System;

namespace modul5_103082400036
{
    public class Penjumlahan
    {
       
        public void JumlahTigaAngka<T>(T a, T b, T c)
        {
           
            dynamic angka1 = a;
            dynamic angka2 = b;
            dynamic angka3 = c;

            Console.WriteLine("Hasil Penjumlahan: " + (angka1 + angka2 + angka3));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan jumlah = new Penjumlahan();
            // Memanggil method dengan tipe int (karena NIM akhiran 6) dan 3 angka 2-digit NIM
            jumlah.JumlahTigaAngka<int>(10, 30, 82);
        }
    }
}