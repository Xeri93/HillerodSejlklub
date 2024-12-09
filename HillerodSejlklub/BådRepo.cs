using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//Codet af Max
namespace HillerodSejlklub
{
    public class BådRepo
    {
        private List<Båd> både;

        public BådRepo()
        {
            både = new List<Båd>();
        }
        //Der bruges CRUD Metoden for denne repo

        //Create
        public void CreateBåd(Båd båd)
        {
            både.Add(båd);
        }

        //Read
        public Båd? ReadBåd(int id)
        {
            foreach (Båd båd in både)
            {
                if (båd.Id == id)
                {
                    return båd;
                }
            }
            return null;
        }
        //Update
        public bool UpdateBåd(int id, Båd UpdateBåd)
        {
            foreach (Båd båd in både)
            {
                if (båd.Id == id)
                {
                    båd.Id = UpdateBåd.Id;
                    båd.Name = UpdateBåd.Name;
                    båd.BådType = UpdateBåd.BådType;
                    båd.Model = UpdateBåd.Model;
                    båd.Sejlnummer = UpdateBåd.Sejlnummer;
                    båd.Motoroplysning = UpdateBåd.Motoroplysning;
                    båd.Mål = UpdateBåd.Mål;
                    båd.Byggeår = UpdateBåd.Byggeår;
                    båd.ErLejebåd = UpdateBåd.ErLejebåd;

                    return true;
                }
            }
            return false;
        }
        //Delete
        public bool DeleteBåd(int id)
        {
            foreach (Båd båd in både)
            {
                if (båd.Id == id)
                {
                    return både.Remove(båd);
                }
            }
            return false;
        }
    }
}
