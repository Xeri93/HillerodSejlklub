using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
    public class Begivenhed
    {
        public int Id;
        public string Titel;
        public DateTime Dato;
		

		public Begivenhed() { }

        public Begivenhed(int id, string titel, DateTime dato)
        {
            Id = id;
            Titel = titel;
            Dato = dato;
        }

        public List<Begivenhed> begivenhedList = new List<Begivenhed>();

        // Adds begivenhed
        public void AddBegivenhed(Begivenhed begivenhed)
        {
            begivenhedList.Add(begivenhed);
        }

		// Går igennem listen af begivenheder, hvis metoden finder id'et så remover den begivenheden, hvis der ikke er matchene id returner metoden false.
		public bool RemoveBegivenhed(int id)
        {
            foreach (Begivenhed begivenhed in begivenhedList)
            {
                if (begivenhed.Id == id)
                {
                    return begivenhedList.Remove(begivenhed);
                }
            }
            return false;
        }

		//Går igennem listen af begivenheder, hvis metoden finder id'et opdatere metoden begivenheden, hvis der ikke er matchene id returnere metoden false.
		public bool UpdateBegivenhed(int id, Begivenhed updatedBegivenhed)
        {
            foreach (Begivenhed begivenhed in begivenhedList)
            {
                if (begivenhed.Id == id)
                {
                    begivenhed.Id = updatedBegivenhed.Id;
                    begivenhed.Titel = updatedBegivenhed.Titel;
                    begivenhed.Dato = updatedBegivenhed.Dato;
                }
            }
            return false;
        }

		//Går igennem listen af begivenheder, hvis metoden finder id'et så returnere den begivenhed objektet, hvis der ikke er matchene id returner metoden null.
		public Begivenhed? ReadBegivenhed(int id)
        {
            foreach (Begivenhed begivenhed in begivenhedList)
            {
                if ( begivenhed.Id == id)
                {
                    return begivenhed;
                }
            }
            return null;
        }
    }
}
