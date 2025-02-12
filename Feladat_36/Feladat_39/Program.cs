using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[10];
            int legnagyobb = 0;
            int legkisebb = 0;
            int pozitcioNagyobb = 0;
            int pozitcioKisebb = 100000;
            int hanyadik = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                hanyadik++;
                tomb[i] = rnd.Next(20,60);
                Console.WriteLine($" {hanyadik,3}. |{tomb[i],5}|");

            }
            int db = 0;
            foreach (int elem in tomb)
            {
                db++;
                if (elem > legnagyobb)
                {
                    legnagyobb = elem;
                    pozitcioNagyobb = db;
                }
                
            }
              int db2 = 0;
            foreach (int elemm in tomb)
            {
                db2++;
                if (elemm < legkisebb)
                {
                    legkisebb = elemm;
                    pozitcioKisebb = db;
                }
            }
            Console.WriteLine($"A legnagyobb szám: {legnagyobb} és a {pozitcioNagyobb}. pozitción helyezkedik el.");
            Console.WriteLine($"A legkisebb szám: {legkisebb} és a {pozitcioKisebb}. pozitción helyezkedik le.");
            Console.ReadKey();
        }
    }
}
