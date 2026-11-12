namespace GyakorlatiFeladat
{
    internal class Program
    {
        static string[] hutoElemek = new string[10];

        static void Feltoltes()
        {
            int hutobenDb = 0;
            while (hutobenDb != hutoElemek.Length)
            {
                Console.Write("Adjon meg egy ételt amit be akar rakni a hűtőbe: ");
                string hutobeValo = Console.ReadLine();
                hutoElemek[hutobenDb] = hutobeValo;
                hutobenDb++;
                Console.WriteLine(hutobenDb);
            }
        }




        static void Main(string[] args)
        {
            Feltoltes();
        }
    }
}
