using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
	public class Blog
	{
		public int Id;
		public string Titel;
		public DateTime Dato;
		public Dictionary<int, Begivenhed> begivenhedDict = new Dictionary<int, Begivenhed>();

		public Blog() { }

		public Blog(int id, string titel, DateTime dato)
		{
			Id = id;
			Titel = titel;
			Dato = dato;
		}

		// Tilføj begivenhed
		public void AddBegivenhed(Begivenhed begivenhed)
		{
			begivenhedDict[begivenhed.Id] = begivenhed;
		}

		// Fjern begivenhed
		public bool RemoveBegivenhed(int id)
		{
			return begivenhedDict.Remove(id);
		}

		// Opdater begivenhed
		public bool UpdateBegivenhed(int id, Begivenhed updatedBegivenhed)
		{
			if (begivenhedDict.ContainsKey(id))
			{
				begivenhedDict[id] = updatedBegivenhed;
				return true;
			}
			return false;
		}

		// Læs begivenhed
		public Begivenhed? ReadBegivenhed(int id)
		{
			begivenhedDict.TryGetValue(id, out Begivenhed? begivenhed);
			return begivenhed;
		}

		// filtrerer efter dato
		public List<Begivenhed> BegivenhedDatoFilter(DateTime filterDato)
		{
			List<Begivenhed> filtreredeBegivenheder = new List<Begivenhed>();

			foreach (var begivenhed in begivenhedDict.Values)
			{
				if (begivenhed.Dato.Date > filterDato.Date)
				{
					filtreredeBegivenheder.Add(begivenhed);
				}
			}
			return filtreredeBegivenheder;
		}
	}
}