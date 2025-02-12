using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[10];
            int pozitiv = 0;
            int negativ = 0;
            int nulla = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(-50, 50);
                Console.WriteLine($"|{tomb[i],5}|");
            }
            foreach (int elem in tomb)
            {
                if (elem == 0)
                {
                    nulla++;
                }
                if (elem >= 1)
                {
                    pozitiv++;
                }
                if(elem <= -1)
                {
                    negativ++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"A Negativ értékek száma: {negativ}");
            Console.WriteLine($"A Pozitiv értékek száma: {pozitiv}");
            Console.WriteLine($"A Nulla értékek száma: {nulla}");
            Console.ReadKey();
        }
    }
}
