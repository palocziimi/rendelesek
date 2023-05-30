using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rendelesek
{
    internal class Rendeles
    {
        int id;
        string termek;
        int mennyiseg;

        public Rendeles(int id, string termek, int mennyiseg)
        {
            this.id = id;
            this.termek = termek;
            this.mennyiseg = mennyiseg;
        }

        public int ID { get => id; }
        public string Termek { get => termek; }
        public int Mennyiseg { get => mennyiseg; }
    }
}
