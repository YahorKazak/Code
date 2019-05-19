using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    //Stwórz funkcję bool CzyIstniejaLiczby(int[] T) ,
    //która zwraca true, jeśli w tablicy T można wybrać takie trzy liczby (na różnych indeksach), których suma jest liczbą pierwszą.
    //W przeciwnym wypadku funkcja zwraca false.
    class Program
    {
        static bool CzyIstniejaLiczby(int[] T)
        {
            int razy = 0;
            int ile = 0;
            int a = 0;
            for (int i = 0; i < T.Length; i++)
            {
                a += T[i];
                razy = 0;
                for (int v = 0; v < T.Length; v++)
                {
                    if (razy != 1)
                    {
                        if (v != i)
                        {
                            a += T[v];
                            for (int c = 0; c < T.Length; c++)
                            {
                                if (c != i && c != v)
                                {
                                    a += T[c];
                                    for (int d = 1; d < a + 1; d++)
                                    {
                                        if (a % d == 0)
                                        {
                                            ile++;
                                        }
                                    }
                                    if (ile == 2)
                                    {
                                        return true;
                                    }
                                    ile = 0;
                                    a = 0;
                                    razy++;
                                }
                            }
                        }
                    }

                }
            }
            return false;

        }
    
            
           
        
        static void Main(string[] args)
        {
            int[] T = {1,0,0};
            Console.WriteLine(CzyIstniejaLiczby(T));
            Console.ReadKey();
        }
    }
}
