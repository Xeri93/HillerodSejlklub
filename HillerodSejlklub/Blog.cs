using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
	public class Blog
	{
		public Dictionary<int, Begivenhed> _begivenheder = new Dictionary<int, Begivenhed>();

		// Add begivenhed
		public void AddBegivenhed(int id, DateTime begivenhedDato, string titel)
		{
			Begivenhed begivenhed = new Begivenhed(id, begivenhedDato, titel);
			_begivenheder.TryAdd(begivenhed.Id, begivenhed);
		}

		// fjerne begivenhed
		public Begivenhed DeleteBegivenhed(int id)
		{
			// Forsøg at fjerne begivenheden og returner den, hvis den blev slettet
			if (_begivenheder.Remove(id, out Begivenhed deletedBegivenhed))
			{
				return deletedBegivenhed;
			}
			else
			{
				return null; // Hvis ingen begivenhed blev fjernet, returner null
			}
		}

		// Get begivenhed
		public Begivenhed GetBegivenhed(int id)
		{
			_begivenheder.TryGetValue(id, out Begivenhed begivenhed);
			return begivenhed;
		}

		// Update begivenhed
		public Begivenhed UpdateBegivenhed(int id, Begivenhed begivenhed)
		{
			if (_begivenheder.ContainsKey(id))
			{
				_begivenheder[id] = begivenhed;
				return begivenhed; // Returner den opdaterede begivenhed
			}
			return null; // Returner null, hvis begivenheden ikke blev fundet
		}

		// Filtrer begivenheder by date
		public List<Begivenhed> FiltrerByDate(DateTime filterDate)
		{
			List<Begivenhed> filteredBegivenheder = new List<Begivenhed>();

			foreach (var begivenhed in _begivenheder.Values)
			{
				if (begivenhed.BegivenhedDato.Date == filterDate.Date)
				{
					filteredBegivenheder.Add(begivenhed);
				}
			}
			return filteredBegivenheder;
		}
	}
}