using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
	public class Begivenhed
	{
		public int Id { get; set; }
		public DateTime BegivenhedDato { get; set; }
		public string Titel { get; set; }

		public Begivenhed() { }

		public Begivenhed(int id, DateTime begivenhedDato, string titel)
		{
			Id = id;
			BegivenhedDato = begivenhedDato;
			Titel = titel;
		}

		public override string ToString()
		{
			return $"ID: {Id}, Dato: {BegivenhedDato.ToString("yyyy-MM-dd HH:mm")}, Titel: {Titel}";
		}
	}
}