using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biler
{
    class Trailer
    {
        private String load = "";
        private bool full;

        // Denne metode tager det oprindelige load of tilføjer
        // et komma efterfulgt af havd man bruger som load parameter

        public void fillTrailer(string load)
        {
            if (this.load != "") this.load = this.load + ", " + load;
            else this.load = load;
            
        }

        public override string ToString()
        {
            return "Traileren indeholder " + load;
        }
    } 
}
