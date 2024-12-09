using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Codet af Max
namespace HillerodSejlklub
{
    public class Vedligeholdelseslog
    {
        public bool ErSejlklar {  get; set; }
        public string FejlBeskrivelse {  get; set; }

        public Vedligeholdelseslog(bool erSejlklar, string fejlBeskrivelse)
        {
            ErSejlklar = erSejlklar;
            FejlBeskrivelse = fejlBeskrivelse;
        }

        public override string ToString()
        {
            return $"{FejlBeskrivelse}";
        }
    }
}
