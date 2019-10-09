using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tal_o_spe
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int gen = rand.Next(1,101);
            int försök = 0;

            Console.WriteLine("skriv ett tal 1-100");
            int tal;

            do
            {
                försök++;
                tal = int.Parse(Console.ReadLine());
                if (tal > gen)
                    Console.WriteLine("talet är för högt");
                else if (tal < gen)
                    Console.WriteLine("talet är för lågt");
                else
                    
                    Console.WriteLine("grattis du gissade rätt tal");
            }
            while (tal != gen);
            Console.WriteLine("du tog " + försök + " försök på dig");
            Console.ReadLine();
        }
    }
}
