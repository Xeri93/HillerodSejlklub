using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
	public class Begivenhed
	{
		public Blog Blog { get; set; }
		public int Id { get; set; }
		public string Titel { get; set; }

		public Begivenhed() { }

		public Begivenhed(Blog blog, int id, string titel)
		{
			Blog = blog;
			Id = id;
			Titel = titel;
		}

		public override string ToString()
		{
			return $"Blog: {Blog}, ID: {Id}, Titel: {Titel}";
		}
	}
}