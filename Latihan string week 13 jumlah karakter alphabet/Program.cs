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
            for (char i = 'a'; i <= 'z'; i++)
            {
                int Sama = InputanKalimat.ToCharArray().Count(c => c == i);
                if (Sama!=0)
                Console.WriteLine($"{i}: {Sama}");
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
