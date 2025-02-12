using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzElsoFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] szamok = new int[30];
            int parosdb = 0;
            int paratlandb = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1,101);
                Console.Write($"|{szamok[i],3}");
            }
            foreach (var elem in szamok)
            {
                if (elem % 2 == 0)
                {
                    parosdb++;
                }
                if (elem % 2 != 0)
                {
                    paratlandb++;
                }
            }
            Console.WriteLine($"A páros számok mennyisége: {parosdb}");
            Console.WriteLine($"A páratlan számok mennyisége: {paratlandb}");

            int[] paros = new int[parosdb];
            int[] paratlan = new int[paratlandb];
            int j = 0;
            int k = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    paros[j] = szamok[i];
                    j++;
                }
                else
                {
                    paratlan[k] = szamok[i];
                    k++;
                }
                
            }
            Console.WriteLine("A páros számok:");
            foreach (var itemm in paros) Console.Write($"{itemm} |");
            
            Console.WriteLine();

            Console.WriteLine("A páratlan számok:");

            foreach (var itemm in paratlan) Console.Write($"{itemm} |");

            
             
            Console.ReadKey();
        }
    }
}
