namespace GyakorlatiFeladat
{
    internal class Program
    {
        static string[] huto = new string[10];

        static int hutobenDb = 0;
        static void Feltoltes()
        {
            Console.Write("Adjon meg egy ételt amit be akar rakni a hűtőbe: ");
            string hutobeValo = Console.ReadLine();
            huto[hutobenDb] = hutobeValo;
            hutobenDb++;
        }

        static void Takarit()
        {
            for (int i = 0; i < huto.Length; i++)
            {

                if (huto[i] == "")
                {

                }
            }
            Console.WriteLine(hutobenDb);
        }



        static void Main(string[] args)
        {
            Feltoltes();
            Takarit();
            Feltoltes();
        }
    }
}
