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
		public string Titel { get; set; }
		public DateTime Dato { get; set; }
		public Blog Blog { get; set; }

		public Begivenhed() { }

		public Begivenhed(int id, string titel, DateTime dato, Blog blog)
		{
			Id = id;
			Titel = titel;
			Dato = dato;
			Blog = blog;
		}

		public override string ToString()
		{
			return $"ID: {Id}, Titel: {Titel}, Dato: {Dato}, Blog: {Blog}";
		}
	}
}