using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler
{
    class Program
    {
        static void Main(string[] args)
        {
            Car citroenCar = new Car("Citroën", "Cactus", 2014);

            Car audicCar = new Car("Audi", "R8", 2008, "Sort", "AB12345", true);
            Console.WriteLine(audicCar);
            Console.WriteLine(citroenCar);

            Console.WriteLine("Trailer test");
            Trailer trailer = new Trailer();

            trailer.fillTrailer("Hækkeaffald");
            Console.WriteLine(trailer);

            trailer.fillTrailer("Gammel Cykel");
            Console.WriteLine(trailer);

        }
    }
}
