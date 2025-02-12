
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[10];
            Console.WriteLine("A Generált számok:");
            for (int i = 0; i < tomb.Length; i++)
            {

                tomb[i] = rnd.Next(100,200);
                Console.Write($" {tomb[i],2} |");

            }
            Console.WriteLine();
            Array.Sort(tomb);
            Array.Reverse(tomb);
            Console.WriteLine($"A három legnagyobb szám: {tomb[0]}|{tomb[1]}|{tomb[2]}");
            Console.ReadKey();
        }
    }
}
