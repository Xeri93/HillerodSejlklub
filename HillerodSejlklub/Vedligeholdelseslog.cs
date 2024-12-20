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
        public int LogId { get; set; } // Unik identifikator for loggen
        public int BådId { get; set; } // Reference til Båd-Id
        public DateTime Dato { get; set; } // Dato for vedligeholdelsen
        public string Beskrivelse { get; set; } // Beskrivelse af arbejdet
        public string UdførtAf { get; set; } // Navn på personen, der udførte arbejdet

        public Vedligeholdelseslog(int logId, int bådId, DateTime dato, string beskrivelse, string udførtAf)
        {
            LogId = logId;
            BådId = bådId;
            Dato = dato;
            Beskrivelse = beskrivelse;
            UdførtAf = udførtAf;
        }

        public override string ToString()
        {
            return $"LogId: {LogId}, BådId: {BådId}, Dato: {Dato.ToShortDateString()}, Beskrivelse: {Beskrivelse}, Udført af: {UdførtAf}";
        }
    }
}