using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    class Program
    {
        static uint IleWyrazow1(string napis)
        {
            int c = 0;
            uint ile = 0;
            for (int i = 0; i < napis.Length; i++)
            {
                if (napis.Length == 0)
                {
                    return 0;
                }
                if (napis.Length == 1)
                {
                    if (napis[0] >= 'A' && napis[0] <= 'Z' || napis[0] >= 'a' && napis[0] <= 'z' || napis[0] >= '0' && napis[0] <= '9')
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                if (napis[i] >= 'A' && napis[i] <= 'Z' && c == 0 || napis[i] >= 'a' && napis[i] <= 'z' && c == 0 || napis[i] >= '0' && napis[i] <= '9' && c == 0)
                {
                    c++;
                }
                if (napis[i] == ' ' && c == 1 )
                {
                    ile++;
                    c = 0;
                }
                if (napis[i] == ' ' && i == napis.Length -1 )
                {
                    
                }
                else
                {
                    if (i == napis.Length -1)
                    {
                        ile++;
                    }
                
                }
               
            }
            return ile;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IleWyrazow2("  jfjgg;fjfgf;"));
            Console.ReadKey();
        }
    }
}
