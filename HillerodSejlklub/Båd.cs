using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
    public class Båd
    {
        public int id { get; set; }
        public string name { get; set; }
        public string bådType { get; set; }
        public string model { get; set; }
        public string sejlnummer { get; set; }
        public string motoroplysning { get; set; }
        public string mål { get; set; }
        public string byggeår { get; set; }
        public bool erLejebåd { get; set; }
        public bool erBooket { get; set; }

        public Båd( int id, string name, string bådType, string model, string sejlnummer,
            string motoroplysning, string mål, string byggeår, bool erLejebåd)
        {

        }

    }
}
