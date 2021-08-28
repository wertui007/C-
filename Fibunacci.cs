using System;
using System.Collections.Generic;
using System.Text;

namespace JakubVyuka
{
    public static class Fibunacci
    {
        public static void Zacit()
        {

            int prvni = 0;
            int druhy = 1;
            int poradi = 2;
            Console.WriteLine("Pro zobrazeni Fibonacciho zmackni libovolnou klavesu");
            Console.ReadLine();
            Console.WriteLine("Fibonaci1= " + prvni);
            Console.WriteLine("Fibonaci2= " + druhy);
            for (int i = 1; i < 31; i++)
            {
                poradi++;
                int soucet = prvni + druhy;
                prvni = druhy;
                druhy = soucet;
                Console.WriteLine("Fibonaci " + poradi + "=" + soucet);
            }

            Menu.MainMenu();
        }

    }  
}