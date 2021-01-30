using System;



namespace API_Test
{
    //
    // found at https://docs.microsoft.com/de-de/dotnet/api/system.random.next?view=net-5.0
    //
    class Wuerfel
    {
        private int ergebnis;
        private Random rnd = new Random();

        public int getErgebnis()
        {
            return this.ergebnis;
        }

        public void wuerfeln()
        {
            ergebnis = rnd.Next(1,7);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Wuerfel w = new Wuerfel();

            for (int i = 0; i < 10; i++)
            {
                w.wuerfeln();
                Console.WriteLine(w.getErgebnis());
            }
        }
    }
}
