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
		public List<Booking> bookings = new List<Booking>();

		// Adds booking
		public void AddBooking(Booking booking)
		{
			bookings.Add(booking);
		}

		// Remove booking
		public bool RemoveBooking(int id)
		{
			foreach (Booking booking in bookings)
			{
				if (booking.Id == id)
				{
					return bookings.Remove(booking);
				}
			}
			return false;
		}

		// Update booking
		public bool UpdatedBooking(int id, Booking updatedBooking)
		{
			foreach (Booking booking in bookings)
			{
				if (booking.Id == id)
				{
					booking.Id = updatedBooking.Id;
					booking.Dato = updatedBooking.Dato;
					booking.ErGodkendt = updatedBooking.ErGodkendt;

					return true;
				}
			}
			return false;
		}

		// Read booking
		public Booking? ReadBooking(int id)
		{
			foreach (Booking booking in bookings)
			{
				if (booking.Id == id)
				{
					return booking;
				}
			}
			return null;
		}
		public List<Booking> SearchMedlem(Medlem medlem)
		{
			List<Booking> result = new List<Booking>();

			foreach (Booking booking in bookings)
			{
				if (booking.Medlem == medlem)
				{
					result.Add(booking);
				}
			}
			return result;
		}
	}

}