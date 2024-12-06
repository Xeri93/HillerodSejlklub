using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
    public class MedlemRepo
    {
        public List<Medlem> medlemmer;

        public MedlemRepo() 
        {
            medlemmer = new List<Medlem>();
        }
        public void CreateMember(Medlem medlem)
        {
            medlemmer.Add(medlem);
        }
    }
}
