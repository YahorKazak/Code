using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD
{
    class Program
    {
        //sriednia arytmetyczna liczb które nie są pierwsze(jezeli nie ma takich liczb return -1)
        static double F1(int[] tablica)
        {
            int ileperwszych = 0;
            double srednia = 0;
            int ileliczb = 0;
            int ile = 0;
            double summa = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int a = 1; a < tablica[i] + 1; a++)
                {
                    if (tablica[i] % a == 0)
                    {
                        ile++;
                    }
                }
                if (ile != 2)
                {
                    summa += tablica[i];
                    ileliczb++;
                }
                if (ile == 2)
                {
                    ileperwszych++;
                }
                ile = 0;
            }
            if (ileperwszych == tablica.Length)
            {
                return -1;
            }
            srednia = summa / ileliczb;
            return srednia;
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
