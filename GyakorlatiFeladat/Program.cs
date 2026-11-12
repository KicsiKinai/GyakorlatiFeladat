using System.Data.Common;
using System.Xml.Serialization;

namespace GyakorlatiFeladat
{
    internal class Program
    {
        static string[] huto = new string[10];

        static string[] hutoTomoritett = new string[10];


        static int hutobenDb = 0;
        static void Feltoltes()
        {
            if (hutobenDb == 10)
            {
                Console.WriteLine("Nincs hely a hűtőben!");
            }
            else
            {
                Console.Write("Adjon meg egy ételt amit be akar rakni a hűtőbe: ");
                string hutobeValo = Console.ReadLine();
                huto[hutobenDb] = hutobeValo;
                hutobenDb++;
            }
        }

        static void Takarit()
        {
            int hutoTomorDb = 0;
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "" && huto[i] != null)
                {
                    hutoTomoritett[hutoTomorDb] = huto[i];
                    hutoTomorDb++;
                }
            }
            Console.WriteLine("A takarított tömbben lévő elemek száma: " + hutoTomorDb);
        }

        static void KeresEtel(string etelNeve)
        {
            int index = 0;
            bool megvan = false;
            while (index != huto.Length && megvan == false)
            {
                if (huto[index] == etelNeve)
                {
                    megvan = true;
                }
                else
                {
                    index++;
                }
            }
            if (index == 10)
            {
                index = 0;
            }
            Console.WriteLine($"Az adott étel ({etelNeve}) indexe: {index}");
        }

        static void MivelKezdodik()
        {
            char[] maganhangzok = { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            Console.Write($"A magánhangóval kezdődő ételek a hűtőben: ");
            for (int i = 0; i < huto.Length; i++)
            {
                foreach (char item in maganhangzok)
                {
                    if (huto[i] != null)
                    {
                        if (huto[i].StartsWith(item))
                        {
                            Console.Write(huto[i] + ", ");
                        }
                    }
                }
            }
        }

        static void Feladat1()
        {
            Feltoltes();
            Feltoltes();
            Feltoltes();
            Feltoltes();
            Feltoltes();
            Takarit();
            KeresEtel("Sajt");
            MivelKezdodik();
        }


        static int[] szamok = new int[10];
        static Random r = new Random();
        static void FeltoltEgyediekkel(int min, int max)
        {
            int index = 0;
            bool van = false;
            Console.Write("A számok: ");
            foreach (int item in szamok)
            {
                int hozzaAdas = r.Next(min, max - 1);
                for (int i = 0; i < szamok.Length - 1; i++)
                {
                    if (szamok[i] == hozzaAdas)
                    {
                        van = true;
                    }
                }
                if (van == false)
                {
                    szamok[index] = hozzaAdas;
                }
                Console.Write($"{szamok[index]}, ");
            }
        }


        static void Feladat2()
        {
            FeltoltEgyediekkel(1, 100);
        }

        static void Main(string[] args)
        {
            //Feladat1();
            Feladat2();
        }
    }
}
