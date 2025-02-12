using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[8] {3,8,5,7,1,2,6,9};
            int csere;
            foreach (var item in szamok)
            {
                Console.Write($"{item} |");
            }
            Console.WriteLine();
            for (int i = 0; i < szamok.Length/2; i++)
            {
                csere = szamok[i];
                szamok[i] = szamok[szamok.Length-1-i];
                szamok[szamok.Length -1 -i] = csere;
            }
            foreach (var item in szamok)
            {
                Console.Write(item + " | ");
            }

        Console.ReadKey();
        }
        
    }
}
