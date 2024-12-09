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

		// Går igennem listen af bookings, hvis metoden finder id'et så remover den bookingen, hvis der ikke er matchene id returner metoden false.
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

		//Går igennem listen af bookings, hvis metoden finder id'et opdatere metoden bookingen, hvis der ikke er matchene id returnere metoden false.
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

		//Går igennem listen af bookings, hvis metoden finder id'et så returnere den bookingen objektet, hvis der ikke er matchene id returner metoden null.
		public Booking? ReadBooking(int id)
		{
			foreach(Booking booking in bookings)
			{
				if (booking.Id == id)
				{
					return booking;
				}
			}
			return null;
		}

	}
}
