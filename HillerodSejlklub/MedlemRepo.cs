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
        public void CreateMedlem(Medlem medlem)
        {
            medlemmer.Add(medlem);
        }
        public Medlem? GetMedlem(int id)
        {
            foreach (var m in medlemmer)
            {
                if (m.Id.Equals(id))
                {
                    return m;
                }
            }
            return null;
        }
    }
}
