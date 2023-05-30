using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rendelesek
{
    internal class Raktar
    {
        String termek;
        int ar;
        int mennyiseg;

        public Raktar(String termek, int ar, int mennyiseg)
        {
            this.termek = termek;
            this.ar = ar;
            this.mennyiseg = mennyiseg;
        }

        public String Termek { get => termek; }
        public int Ar { get => ar; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
    }
}
