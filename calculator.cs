using System;

namespace CalculatorApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi kalkulator");

            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Inputkan oprasi = ");
            int opsi = int.Parse(Console.ReadLine());
            if(opsi==1)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (opsi == 2)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Pengurangan " + a + " + " + b + " = " + Pengurangan(a, b));
            }
            else if (opsi == 3)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Perkalian " + a + " + " + b + " = " + Perkalian(a, b));
            }
            else if (opsi == 4)
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil Pembagian " + a + " + " + b + " = " + Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("\nMaaf operasi yang anda pilih tidak tersedia");
                Console.WriteLine();
            }
            Console.WriteLine("\nTekan Sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }

    }
}
