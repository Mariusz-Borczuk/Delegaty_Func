using System;

namespace Delefaty____________
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 2 liczby całkowite");
            int liczba1 = int.Parse(Console.ReadLine());
            int liczba2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj jakie działanie chcemy wykonać");
            string jakieDzialanieRobimy = Console.ReadLine();
            Func<int, int, int> dun;

            NadajDzialanieDlaDelegata(out dun, jakieDzialanieRobimy);
            WykonajDzialanie(liczba1, liczba2, dun);

        }


        private static void WykonajDzialanie(int l1, int l2, Func<int, int, int> dun)
        {
            int wynikDzialania = dun(l1, l2);
            Console.WriteLine(wynikDzialania);
        }

        private static void NadajDzialanieDlaDelegata(out Func<int, int, int> dun, string jakieDzialanieRobimy)
        {
            switch (jakieDzialanieRobimy.ToLower())
            {
                case ("dodawanie"):
                    dun = (Dodawanie);
                    return;
                case ("odejmowanie"):
                    dun = (Odejmowanie);

                    return;
                case ("mnozenie"):
                    dun = (Mnozenie);

                    return;
                default:
                    dun = (Inne);

                    return;
            }
        }

        static int Dodawanie(int l1, int l2)
        {
            return l1 + l2;
        }
        static int Odejmowanie(int l1, int l2)
        {
            return l1 - l2;
        }
        static int Mnozenie(int l1, int l2)
        {
            return l1 * l2;
        }
        static int Inne(int l1, int l2)
        {
            return (l1 - l2) * 2 * l1 + l2;
        }
    }
}
