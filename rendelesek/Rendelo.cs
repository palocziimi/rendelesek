using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rendelesek
{
    internal class Rendelo
    {
        String datum;
        int id;
        String email;
        bool teljesitheto = true;

        public Rendelo(string datum, int id, string email)
        {
            this.datum = datum;
            this.id = id;
            this.email = email;
        }

        public String Datum { get => datum; }
        public int ID { get => id; }
        public String Email { get => email; }
        public bool Teljesitheto { get => teljesitheto; set => teljesitheto = value; }
    }
}
