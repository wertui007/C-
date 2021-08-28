using System;
namespace JakubVyuka
{
    public static class Kalkulajda
    {
        public static void Start()
        {
            Console.WriteLine(" --- Vitejte na kalkulacce --- ");

            string znamenko = GetZnamenko();

            Console.WriteLine("Zadej hodnotu 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadej hodnotu 2: ");
            int b = int.Parse(Console.ReadLine());

            float vysledek = 0;

            if (znamenko == "+")
            {
                vysledek = Soucet(a, b);


                Console.WriteLine(a + " " + znamenko + " " + b + " = " + vysledek);

            }
            if (znamenko == "-")
            {
                vysledek = Rozdil(a, b);

                Console.WriteLine(a + " " + znamenko + " " + b + " = " + vysledek);
            }
            if (znamenko == "*")
            {
                vysledek = Soucin(a, b);

                Console.WriteLine(a + " " + znamenko + " " + b + " = " + vysledek);
            }
            if (znamenko == "/")
            {
                vysledek = Podil(a, b);

                Console.WriteLine(a + " " + znamenko + " " + b + " = " + vysledek);
            }
            Menu.MainMenu();
        }
        public static string GetZnamenko()
        {
            string znamenko = null;

            while (znamenko == null)
            {
                Console.WriteLine("Zadejte znamenko [+-/*]: ");
                string vstup = Console.ReadLine();

                if (vstup == "+"
                   || vstup == "-"
                   || vstup == "/"
                   || vstup == "*")
                {
                    znamenko = vstup;
                }
                else
                {
                    Console.WriteLine("Spatne znamenko");
                }
            }

            return znamenko;
        }

        public static int Soucet(int a, int b)
        {
            return a + b;
        }
        public static int Rozdil(int a, int b)
        {
            return a - b;
        }

        public static int Soucin(int a, int b)
        {
            return a * b;
        }

        public static int Podil(int a, int b)
        {
            return a / b;
        }
    }
}
