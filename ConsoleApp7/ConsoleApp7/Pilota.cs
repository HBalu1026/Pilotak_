using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Pilota
    {
        string nev;
        string datum;
        string nemzetiseg;
        int rajtszam;

        public Pilota(string nev, string datum, string nemzetiseg, int rajtszam)
        {
            this.nev = nev;
            this.datum = datum;
            this.nemzetiseg = nemzetiseg;
            this.rajtszam = rajtszam;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Datum { get => datum; set => datum = value; }
        public string Nemzetiseg { get => nemzetiseg; set => nemzetiseg = value; }
        public int Rajtszam { get => rajtszam; set => rajtszam = value; }
    }
}
