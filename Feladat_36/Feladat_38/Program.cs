using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tomb = new int[10];
            int legnagyobb = 0;
            int pozitcio = 0;
            int hanyadik=0;
            for (int i = 0; i < tomb.Length; i++)
            {
                hanyadik++;
                tomb[i] = rnd.Next(200,300);
                Console.WriteLine($" {hanyadik,3}. |{tomb[i],5}|");

            }
            int db=0;
            foreach (int elem in tomb)
            {
                db++;
                if (elem > legnagyobb)
                {
                    legnagyobb=elem;
                    pozitcio = db;
                }
            }
            Console.WriteLine($"A legnagyobb szám: {legnagyobb} és a {pozitcio}. pozitción helyezkedik el.");
            Console.ReadKey();
        }
    }
}
