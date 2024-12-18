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
		public Medlem Medlem { get; set; }
		public Båd Båd { get; set; }
		public DateTime BookingDato { get; set; }
		public bool ErGodkendt { get; set; }
		public Booking() { }

		public Booking(int id, Medlem medlem, Båd båd, DateTime bookingDato, bool erGodkendt)
		{
			Id = id;
			Medlem = medlem;
			Båd = båd;
			BookingDato = bookingDato;
			ErGodkendt = erGodkendt;
		}

		public override string ToString()
		{
			return $"ID: {Id}, Medlem: {Medlem}, Båd: {Båd},  Dato: {BookingDato.ToString("yyyy-MM-dd HH:mm")}, Booket: {ErGodkendt}";
		}
	}
}