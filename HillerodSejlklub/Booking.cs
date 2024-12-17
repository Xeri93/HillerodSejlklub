using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
	public class Booking
	{
		public int Id { get; set; }
		public DateTime Dato { get; set; }
		public bool ErGodkendt { get; set; }
		public Båd Båd { get; set; }
		public Medlem Medlem { get; set; }

		public Booking() { }

		public Booking(int id, DateTime dato, bool erGodkendt, Båd båd, Medlem medlem)
		{
			Id = id;
			Dato = dato;
			ErGodkendt = erGodkendt;
			Båd = båd;
			Medlem = medlem;
		}

		public override string ToString()
		{
			return $"ID: {Id}, Dato: {Dato}, Booket: {ErGodkendt}, Medlem: {Medlem}, Båd: {Båd}";
		}
	}
}