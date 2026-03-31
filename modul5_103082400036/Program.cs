using System;
using System.Collections.Generic;

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


    public class SimpleDataBase<T>
        {
            public List<T> storedData {
                get;
                set;
            }
            public List<DateTime> inputDates {
                get;
                set;
            }

            public SimpleDataBase()
            {
                storedData = new List<T>();
                inputDates = new List<DateTime>();
            }

            public void AddNewData(T data)
            {
                storedData.Add(data);
                inputDates.Add(DateTime.UtcNow);
            }

            public void PrintAllData()
            {
                for (int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
                }

            }
        }

        class Program
        {
            static void Main(string[] args)
            {

                Penjumlahan jumlah = new Penjumlahan();
                // Memanggil method dengan tipe int (karena NIM akhiran 6) dan 3 angka 2-digit NIM
                jumlah.JumlahTigaAngka<int>(10, 30, 82);

                SimpleDataBase<int> db = new SimpleDataBase<int>();

                // Menambahkan 3 data NIM (10, 30, 82)
                db.AddNewData(10);
                db.AddNewData(30);
                db.AddNewData(82);

                db.PrintAllData();

            }
        }
    }
