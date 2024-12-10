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
        //Create metode
        public void CreateMedlem(Medlem medlem)
        {
            medlemmer.Add(medlem);
        }
        // Read metode
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
        //Update metode
        public bool UpdateMedlem(int id, Medlem medlem)
        {
            foreach (var m in medlemmer)
            {
                if (m.Id.Equals(id))
                {
                    m.Id = medlem.Id;
                    m.Navn = medlem.Navn;
                    m.Email = medlem.Email;
                    m.Tlf = medlem.Tlf;
                    m.HarEgenBåd = medlem.HarEgenBåd;
                    return true;
                }
            }
            return false;
        }

            //Delete metode
            public Medlem? DeleteMedlem(int id)
            {
                foreach (var m in medlemmer)
                {
                    if (m.Id.Equals(id)) medlemmer.Remove(m);
                    return m;
                }
                return null;
            }
    }
}
