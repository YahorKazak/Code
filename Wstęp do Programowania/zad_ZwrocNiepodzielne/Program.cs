using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    //Stwórz funkcję: string ZwrocNiepodzielne(uint n) Funkcja zwraca w postaci tekstu ciąg kolejnych liczb całkowitych znajdujących się między liczbą 0 a liczbą n przesłaną jako argument funkcji,
    //które są niepodzielne przez 3 lub przez 5 (lub przez obydwie z tych liczb).
    //Tekst ma zawierać liczby w kolejności rosnącej, w jednej linii, oddzielone spacją od siebie, np: "1 2 4 7" (bez cudzysłowu).
    //Przed pierwszą liczbą oraz po ostatniej liczbie brak spacji. Problem należy rozwiązać, stosując rekurencyjne wywołanie funkcji.
    class Program
    {
        static string ZwrocNiepodzielne(uint n)
        {
            if (n == 0)
            {
                return "";
            }
            if (n == 1)
            {
                return "" + n;
            }
          
            if (n % 3 != 0 && n % 5 != 0)
            {
              
                    string wynik = ZwrocNiepodzielne(n - 1) + " " + Convert.ToString(n) ;
                    return wynik ;
                
               
            }
            else
            {
               return ZwrocNiepodzielne(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocNiepodzielne(6));
            Console.ReadKey();
        }
    }
}
