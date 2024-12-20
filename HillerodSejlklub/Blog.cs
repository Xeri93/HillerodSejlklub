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
		public Dictionary<int, Begivenhed> begivenhedDict = new Dictionary<int, Begivenhed>();
		public Blog() { }

		public Blog(int id, string titel)
		{
			Id = id;
			Titel = titel;
		}

		public override string ToString()
		{
			return $"Id: {Id}, Titel: {Titel}";
		}
		// Tilføj begivenhed
		public bool AddBegivenhed(Begivenhed begivenhed)
		{
			if (begivenhedDict.ContainsKey(begivenhed.Id))
			{
				begivenhedDict[begivenhed.Id] = begivenhed;
				return true;
			}
			return false;
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
		//public List<Begivenhed> BegivenhedDatoFilter(DateTime filterDato)
		//{
		//	List<Begivenhed> filtreredeBegivenheder = new List<Begivenhed>();

		//	foreach (var begivenhed in begivenhedDict.Values)
		//	{
		//		if (begivenhed.Dato.Date > filterDato.Date)
		//		{
		//			filtreredeBegivenheder.Add(begivenhed);
		//		}
		//	}
		//	return filtreredeBegivenheder;
		//}
	}
}