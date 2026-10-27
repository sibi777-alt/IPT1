using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menge;
            bool gueltig;

            for (gueltig = false; !gueltig;)
            {
                Console.WriteLine("Menge:");
                menge = Convert.ToInt32(Console.ReadLine());

                if (menge > 0)
                {
                    gueltig = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Menge.");
                }
            }

            Console.WriteLine("Menge übernommen: " + menge);
        }

    }
}