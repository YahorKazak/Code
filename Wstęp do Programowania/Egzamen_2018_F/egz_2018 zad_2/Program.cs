using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD
{
    class Program
    {
        // return ostatni wyraz w którym ilość samoglosków równa się ilościu spógłosków(jeżeli nie ma takiego wyrazu return !)
        static string F2(string tekst)
        {
            string wynik = "";
            int samogłoski = 0;
            int spolgloski = 0;
            string word = "";
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] < 'A' || tekst[i] > 'Z' && tekst[i] < 'a' || tekst[i] > 'z')
                {
                    for (int a = 0; a < word.Length; a++)
                    {
                        if (word[a] == 'A' || word[a] == 'E' || word[a] == 'Y' || word[a] == 'U' || word[a] == 'O' || word[a] == 'I' ||
                            word[a] == 'a' || word[a] == 'e' || word[a] == 'y' || word[a] == 'u' || word[a] == 'o' || word[a] == 'i')
                        {
                            samogłoski++;
                        }
                        else
                        {
                            spolgloski++;
                        }
                    }
                    if (samogłoski == spolgloski && word != "")
                    {
                        wynik = word;
                    }
                    word = "";
                    samogłoski = 0;
                    spolgloski = 0;
                }
                if (tekst[i] >= 'A' && tekst[i] <= 'Z' || tekst[i] >= 'a' && tekst[i] <= 'z')
                {
                    word += tekst[i];
                }
                if (i == tekst.Length - 1)
                {
                    for (int a = 0; a < word.Length; a++)
                    {
                        if (word[a] == 'A' || word[a] == 'E' || word[a] == 'Y' || word[a] == 'U' || word[a] == 'O' || word[a] == 'I' ||
                            word[a] == 'a' || word[a] == 'e' || word[a] == 'y' || word[a] == 'u' || word[a] == 'o' || word[a] == 'i')
                        {
                            samogłoski++;
                        }
                        else
                        {
                            spolgloski++;
                        }
                    }
                    if (samogłoski == spolgloski && word != "")
                    {
                        wynik = word;
                    }
                    word = "";
                    samogłoski = 0;
                    spolgloski = 0;
                }
            }
            if (wynik == "")
            {
                return "!";
            }
            else
            {
                return wynik;
            }
        }
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
