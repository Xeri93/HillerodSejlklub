using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HillerodSejlklub
{
	public class BookingRepo
	{
		public List<Booking> bookinger;

		public BookingRepo()
		{
			bookinger = new List<Booking>();
		}

		// Create metode
		public void CreateBooking(Booking booking)
		{
			bookinger.Add(booking);
		}

		// Read metode
		public Booking? GetBooking(int id)
		{
			foreach (var b in bookinger)
			{
				if (b.Id.Equals(id))
				{
					return b;
				}
			}
			return null;
		}

		// Update metode
		public bool UpdateBooking(int id, Booking booking)
		{
			foreach (var b in bookinger)
			{
				if (b.Id.Equals(id))
				{
					b.Id = booking.Id;
					b.Medlem = booking.Medlem;
					b.Båd = booking.Båd;
					b.BookingDato = booking.BookingDato;
					b.ErGodkendt = booking.ErGodkendt;
					return true;
				}
			}
			return false;
		}

		// Delete metode
		public Booking? DeleteBooking(int id)
		{
			foreach (var b in bookinger)
			{
				if (b.Id.Equals(id))
				{
					bookinger.Remove(b);
					return b;
				}
			}
			return null;
		}

		public List<Booking> SearchBookingByDate(DateTime searchDate)
		{
			// Opret en liste til de fundne bookinger
			List<Booking> result = new List<Booking>();

			// Gennemgå alle bookinger
			foreach (Booking booking in bookinger)
			{
				// Hvis datoen matcher (uden tid) så tilføj booking til resultatet
				if (booking.BookingDato.Date == searchDate.Date)
				{
					result.Add(booking);
				}
			}
			return result;
		}
	}
}