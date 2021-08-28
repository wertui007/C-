using System;
namespace JakubVyuka
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("---- MENU -----");
            Console.WriteLine("1. Fibonachi");
            Console.WriteLine("2. Faktorial");
            Console.WriteLine("3. Kalkulajda");
            Console.WriteLine("4. Settings");

            int vstup = Vstup(1, 4);

            if (vstup == 1)
            {
                Fibunacci.Zacit();
            }

            if (vstup == 2)
            {
                Faktorial.odpalit();
            }

            if (vstup == 3)
            {
                Kalkulajda.Start();
            }

            if (vstup == 4)
            {
                Menu2();
            }
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

        public static void Menu2()
        {
            Console.WriteLine(" --- PODMENU SETTING --- ");
            Console.WriteLine("1. navrat do menu");
            Console.WriteLine("2. Exit");

            int vstup = Vstup(1, 2);

            if (vstup == 1)
            {
                MainMenu();
            }
        }
    }
}
