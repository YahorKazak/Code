using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    //Stwórz funkcję int[] Uporzadkuj(int[] T) , 
    //która uporządkuje elementy tablicy T i zwróci tablicę uporządkowaną w następującym porządku:
    //elementy na indeksach nieparzystych z tablicy T należy uporządkować niemalejąco w zwracanej tablicy, 
    //a elementy na pozostałych indeksach należy uporządkować nierosnąco.
    class Program
    {
      static int[] Uporzadkuj(int[] T)
        {
           

            for (int i = 0; i < T.Length; i++)
            {
                for (int v = 0; v < T.Length; v++)
                {
                    if (i % 2 != 0 && v % 2 != 0)
                    {
                        if (T[i] < T[v])
                        {
                            int a = T[v];
                            T[v] = T[i];
                            T[i] = a;
                        }
                    }
                    if(i % 2 == 0 && v % 2 == 0) 
                    {
                        if (T[i] > T[v])
                        {
                            int a = T[i];
                            T[i] = T[v];
                            T[v] = a;
                        }
                    }
                }
            }
            
            return T;
        }
        static void Main(string[] args)
        {
            int[] T = {};
            Uporzadkuj(T);
            Console.ReadKey();
        }
    }
}
