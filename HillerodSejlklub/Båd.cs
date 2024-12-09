﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Codet af Max
namespace HillerodSejlklub
{
    public class Båd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BådType { get; set; }
        public string Model { get; set; }
        public string Sejlnummer { get; set; }
        public string Motoroplysning { get; set; }
        public string Mål { get; set; }
        public string Byggeår { get; set; }
        public bool ErLejebåd { get; set; }
        public bool ErBooket { get; set; }

        public Båd( int id, string name, string bådType, string model, string sejlnummer,
            string motoroplysning, string mål, string byggeår, bool erLejebåd)
        {
            Id = id;
            Name = name;
            BådType = bådType;
            Model = model;
            Sejlnummer = sejlnummer;
            Motoroplysning = motoroplysning;
            Mål = mål;
            Byggeår = byggeår;
            ErLejebåd = erLejebåd;
        }

    }
}
