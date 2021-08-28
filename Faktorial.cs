using System;
using System.Collections.Generic;
using System.Text;

namespace JakubVyuka
{
    public static class Faktorial
    {

        public static void odpalit()
        {
            Console.WriteLine("1. Cely faktorial");
            Console.WriteLine("2. Faktorial od 6 nahoru");
            int vstup = Vstup(1, 2);
            if (vstup == 1)
            {
                cely();
            }

            if (vstup == 2)
            {
                pulka();
            }
        }
            public static void cely()
        {
            int prvni = 1;
            int druhy = 2;
            int poradi = 2;
            Console.WriteLine("Faktorial 1 je 0");
            Console.WriteLine("Faktorial 2 je 1");
            for (int i = 1; i < 10; i++)
            {
                int soucin = prvni * druhy;
                prvni = soucin;
                druhy++;
                poradi++;
                Console.WriteLine("Faktorial " + poradi + " je " + soucin);
            }

            Menu.MainMenu();
        }
        public static int Vstup(int dolniInterval, int horniInterval)
        {
            int pReturn = 0;

            while (pReturn == 0)
            {
                int vstup = int.Parse(Console.ReadLine());

                if (vstup >= dolniInterval && vstup <= horniInterval)
                {
                    pReturn = vstup;
                }
                else
                {
                    Console.WriteLine("Spatny vstup");
                }
            }

            return pReturn;
        }
        public static void pulka()
        {
                  
                int prvni = 24;
                int druhy = 5;
                int poradi = 5;
                for (int i = 5; i < 10; i++)
                    {
                        int soucin = prvni * druhy;
                        prvni = soucin;
                        druhy++;
                        poradi++;
                        Console.WriteLine("Faktorial " + poradi + " je " + soucin);
                    }
            Menu.MainMenu();
        }
    }
}
