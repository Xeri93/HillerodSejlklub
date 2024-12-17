using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
    //Kodeansvarlig - Tobias
    public class Medlem
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Tlf { get; set; }
        public bool HarEgenBåd { get; set; }

        public Medlem() { }
        public Medlem(int id, string navn, string email, string tlf, bool harEgenBåd)
        {
            Id = id;
            Navn = navn;
            Email = email;
            Tlf = tlf;
            HarEgenBåd = harEgenBåd;
        }
        public override string ToString()
        {
            return $"{Id}\n{Navn}\n{Email}\n{Tlf}\n{HarEgenBåd}";
        }
    }
}
