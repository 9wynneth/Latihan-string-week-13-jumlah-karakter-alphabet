using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Latihan_string_week_13_jumlah_karakter_alphabet
{
    class Program
    {
        static void StatistikHuruf(string InputanKalimat)
        {
            Console.WriteLine("STATISTIK HURUF:");
            if (InputanKalimat.Contains("a"))
            {
                char HurufA = 'a';
                int count = InputanKalimat.Count(s => s == HurufA);
                Console.WriteLine($"A: {count}");
                if (InputanKalimat.Contains("b"))
                {
                    char HurufB = 'b';
                    int count2 = InputanKalimat.Count(s => s == HurufB);
                    Console.WriteLine($"B: {count2}");
                    if (InputanKalimat.Contains("c"))
                    {
                        char HurufC = 'c';
                        int count3 = InputanKalimat.Count(s => s == HurufC);
                        Console.WriteLine($"C: {count3}");
                        if (InputanKalimat.Contains("d"))
                        {
                            char HurufD = 'd';
                            int count4 = InputanKalimat.Count(s => s == HurufD);
                            Console.WriteLine($"D: {count4}");
                            if (InputanKalimat.Contains("e"))
                            {
                                char HurufE = 'e';
                                int count5 = InputanKalimat.Count(s => s == HurufE);
                                Console.WriteLine($"E: {count5}");
                            }
                        }
                    }
                }

            }
        }
        static void StatistikKata(string InputanKata, string InputanKalimat)
        {
            Console.WriteLine("STATISTIK KATA:");
            int Hitung = 0;
            foreach (Match sama in Regex.Matches(InputanKalimat, InputanKata))
            {
                Hitung++;
            }
            Console.WriteLine($"{InputanKata.ToUpper()}: {Hitung} KATA\n");
        }
        static void JumlahHuruf(string InputanKalimat)
        {
            Console.Write($"Jumlah huruf pada kalimat adalah: {InputanKalimat.Replace(" ", "").Length}");

        }
        static void Main(string[] args)
        {
            Console.Write("MOHON MEMBERI INPUTAN TANPA MENGGUNAKAN HURUF BESAR (KAPITAL), SISTEM AKAN OTOMATIS MERUBAH INPUTAN MENJADI HURUF BESAR (KAPITAL) \nINPUT KALIMAT:");
            string InputanKalimat = Console.ReadLine();
            string[] Potongan = InputanKalimat.Split(" ");
            while (Potongan.Length <= 3)
            {
                Console.Write("KATA PADA KALIMAT KURANG PANJANG \nINPUT KALIMAT:");
                InputanKalimat = Console.ReadLine();
                Potongan = InputanKalimat.Split(" ");
            }
            Console.WriteLine();
            Console.Write("INPUT KATA: ");
            string InputanKata = Console.ReadLine();
            while (InputanKata.Length <= 1)
            {
                Console.Write("HURUF PADA KATA KURANG PANJANG \nINPUT KATA:");
                InputanKata = Console.ReadLine();
            }
            Console.Clear();
            Console.Write($"INPUT KALIMAT: {InputanKalimat.ToUpper()}\n");
            Console.WriteLine($"INPUT KATA: {InputanKata.ToUpper()}\nOUTPUT:");
            StatistikHuruf(InputanKalimat);
            StatistikKata(InputanKata, InputanKalimat);
            JumlahHuruf(InputanKalimat);
        }
    }
}
