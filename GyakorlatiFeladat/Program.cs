using System.Data.Common;
using System.Security.Principal;
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
            int hozzaAdas;
            Console.Write("A számok: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                bool van = false;
                do
                {
                    van = false;
                    hozzaAdas = r.Next(min, max - 1);
                    for (int j = 0; j < szamok.Length; j++)
                    {
                        if (szamok[j] == hozzaAdas)
                        {
                            van = true;
                        }
                    }
                }
                while (van == true);
                szamok[i] = hozzaAdas;
                Console.Write($"{szamok[i]}, ");
            }
        }

        static int[] LeghosszabbNovekvo()
        {
            int elozo = szamok[0];
            bool sorrendVan = false;
            int sorrendIndex = 0;
            int sorrendHossz = 1;
            for (int i = 1; i < szamok.Length - 1; i++)
            {
                if (elozo + 1 == szamok[i])
                {
                    sorrendIndex = i - 1;
                    sorrendVan = true;
                    sorrendHossz++;
                }
                elozo = szamok[i];
            }
            int[] szamSorrend = new int[sorrendHossz];
            if (sorrendVan == true)
            {
                for (int i = 0; i < sorrendHossz; i++)
                {
                    szamSorrend[i] = szamok[sorrendIndex];
                    sorrendIndex++;
                }
            }
            return szamSorrend;
        }

        static void AtlagAlattiDuplazas()
        {
            int szamokSum = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                szamokSum += szamok[i];
            }

            double atlag = (double)szamokSum / szamok.Length;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < atlag)
                {
                    szamok[i] *= 2;
                }
            }
            Console.Write("Az átlag alatti elemek duplázása után: ");
            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + ", ");
            }
        }

        static void Feladat2()
        {
            FeltoltEgyediekkel(1, 15);
            Console.WriteLine("");
            int [] szamSorrend = LeghosszabbNovekvo();
            if (szamSorrend.Length == 1)
            {
                Console.Write("Nincs benne egy növekvő sorrend sem!");
            }
            else
            {
                Console.Write("A leghosszabb növekedő számsorrend: ");
                for (int i = 0; i < szamSorrend.Length; i++)
                {
                    Console.Write($"{szamSorrend[i]}, ");
                }
            }
            Console.WriteLine();
            AtlagAlattiDuplazas();
        }

        static void Main(string[] args)
        {
            //Feladat1();
            Feladat2();
        }
    }
}
