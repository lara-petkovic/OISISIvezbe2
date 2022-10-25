using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_sa_3
{
    class Program
    {

        static void Main(string[] args)
        {
            int broj;
            bool ok = false;
            string brojS = Console.ReadLine();
            broj = Convert.ToInt32(brojS);
            while (broj != 0)
            {
                if (broj % 10 == 3)
                {
                    ok = true;
                    break;
                }
                broj /= 10;
            }
            if (ok)
                Console.WriteLine("Sadrzi 3");
            else
                Console.WriteLine("Ne sadrzi 3");

            Console.ReadKey();
        }

    }
}
