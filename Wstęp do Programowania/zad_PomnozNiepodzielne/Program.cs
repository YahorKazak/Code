using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    //Stwórz funkcję: long PomnozNiepodzielne(int n)
    //Funkcja rekurencyjnie oblicza iloczyn wszystkich liczb całkowitych znajdujących się między liczbą n przesłaną jako argument funkcji a liczbą 0 (wyłączając 0),
    //które jednocześnie spełniają obydwa warunki: są niepodzielne przez 7 oraz niepodzielne przez 5. Dla n = 0 funkcja zwraca 0.
    class Program
    {
        static long PomnozNiepodzielne(int n)
        {
            if (n>=0)
            {
                if (n == 1)
                {
                    return 1;
                }
                int c = 0;
                while (c == n)
                {
                    return 0;
                }
                if (n % 7 != 0 && n % 5 != 0)
                {
                    long wynik = n * PomnozNiepodzielne(n - 1);
                    return wynik;
                }
                else
                {
                    return PomnozNiepodzielne(n - 1);
                }
            }
            else
            {
                if (n == -1)
                {
                    return -1;
                }
                int c = 0;
                while (c == n)
                {
                    return 0;
                }
                if (n % 7 != 0 && n % 5 != 0)
                {
                    long wynik = n * PomnozNiepodzielne(n + 1);
                    return wynik;
                }
                else
                {
                    return PomnozNiepodzielne(n + 1);
                }
            }
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PomnozNiepodzielne(-5));
            Console.ReadKey();
        }
    }
}
