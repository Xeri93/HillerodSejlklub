namespace HillerodSejlklub
{
    public class HellerodSejlklub
    {
        static void Main()
        {
            //Create ny båd
            Båd båd1 = new Båd(1, "Armadillo", "Sejlskib", "xdd", "123"
                , "mega god motor", "5m x 4.20m x 6.9m", "2000", false);
			Båd båd2 = new Båd(2, "Shark", "Jolle", "Mercury", "32", "Benzin motor", "14 fod", "2002", true);
            BådRepo bådrepo = new BådRepo();
            bådrepo.CreateBåd(båd1);
            Console.WriteLine(bådrepo.ReadBåd(1));

            //Create ny Vedligeholdelseslog
            VedligeholdelseslogRepo logRepo = new VedligeholdelseslogRepo();
            Vedligeholdelseslog log = new Vedligeholdelseslog(1, 1, DateTime.Now, "Motorservice udført", "Henrik Hansen");
            logRepo.CreateLog(log);
            Console.WriteLine(logRepo.GetLog(1));

			Console.WriteLine("-----Begivenhed start-----");
			// Opret begivenheder
			Begivenhed begivenhed1 = new Begivenhed(1, new DateTime(2024, 12, 25, 18, 30, 0), "Sport");
			Begivenhed begivenhed2 = new Begivenhed(2, new DateTime(2024, 12, 25, 12, 00, 0), "Sejlads");

			// Add begivenheder til blog
			Blog blog = new Blog();
			Console.WriteLine("Begivenheder i bloggen:");
			blog.AddBegivenhed(begivenhed1.Id, begivenhed1.BegivenhedDato, begivenhed1.Titel);
			blog.AddBegivenhed(begivenhed2.Id, begivenhed2.BegivenhedDato, begivenhed2.Titel);

			// Skriver begivenheder ud
			foreach (var begivenhed in blog._begivenheder.Values)
			{
				Console.WriteLine(begivenhed.ToString());
			}

			Console.WriteLine("\nTest af UpdateBegivenhed");
			Begivenhed updatedEvent = blog.UpdateBegivenhed(1, new Begivenhed(1, new DateTime(2024, 12, 25, 20, 0, 0), "Opdateret Sport"));

			if (updatedEvent != null)
			{
				Console.WriteLine("Opdateret begivenhed: " + updatedEvent.ToString());
			}
			else
			{
				Console.WriteLine("Begivenheden blev ikke fundet og kunne ikke opdateres.");
			}

			// Fundne begivenheder
			Console.WriteLine("\nTest af GetBegivenhed");
			Begivenhed fundetBegivenhed = blog.GetBegivenhed(begivenhed1.Id);

			if (fundetBegivenhed != null)
			{
				Console.WriteLine("Fundet begivenhed: " + fundetBegivenhed.ToString());
			}
			else
			{
				Console.WriteLine("Begivenheden blev ikke fundet.");
			}

			// Filtrer på datoen 25 december 2024 
			DateTime filterDate = new DateTime(2024, 12, 25);
			List<Begivenhed> begivenhederForDate = blog.FiltrerByDate(filterDate);

			// Udskriv de filtrerede begivenheder
			foreach (var begivenhed in begivenhederForDate)
			{
				Console.WriteLine(begivenhed);
			}

			// Fjernelse af begivenhed
			Console.WriteLine("\nTest af DeleteBegivenhed");
			Begivenhed deletedBegivenhed = blog.DeleteBegivenhed(begivenhed1.Id);

			if (deletedBegivenhed != null)
			{
				Console.WriteLine("Begivenhed slettet: " + deletedBegivenhed.ToString());
			}
			else
			{
				Console.WriteLine("Begivenheden kunne ikke slettes, da den ikke blev fundet.");
			}

			Console.WriteLine("\n-----Begivenhed slut-----");

            //Medlem test
            Console.WriteLine();
            Console.WriteLine("Medlem test start\n");
            MedlemRepo medlemRepo = new MedlemRepo();
            Medlem medlem1 = new Medlem(1, "Tobias", "tobias.test@gmail.com", "82938183", false);
            Medlem medlem2 = new Medlem(2, "Thor", "thor.test@gmail.com", "28490295", true);
            Medlem medlem3 = new Medlem(3, "Adam", "adam.test@gmail.com", "92749729", false);
            //Create test
            medlemRepo.CreateMedlem(medlem1);
            medlemRepo.CreateMedlem(medlem2);
            medlemRepo.CreateMedlem(medlem3);
            Console.WriteLine("Create method test");
            Console.WriteLine($"Registrerede medlemmer i Create test: {medlemRepo.medlemmer.Count}");

            Console.WriteLine();

            //Read test
            Console.WriteLine("Read method test");
            var readMedlem = medlemRepo.GetMedlem(1);
            if (readMedlem != null)
            {
                Console.WriteLine($"GetMedlem registrerede: {readMedlem.Navn} - {readMedlem.Email}");
            }
            Console.WriteLine();

            //Update test
            Console.WriteLine("Update method test");
            Console.WriteLine("Medlem før Update");
            Console.WriteLine(medlem1);
            medlemRepo.UpdateMedlem(1, new Medlem(1, "Tobias", "TobiasNyMail@gmail.com", "82938183", true));
            Console.WriteLine("\nMedlem efter Update");
            Console.WriteLine(medlem1);

            //Delete test
            Console.WriteLine("\nDelete method test");
            medlemRepo.DeleteMedlem(1);
            Console.WriteLine($"Registrerede medlemmer efter Delete Test: {medlemRepo.medlemmer.Count}");

            //SearchMedlemByEmail test
            Console.WriteLine("\nSearchMedlemByEmail method test");
            var search = medlemRepo.SearchMedlemByEmail("thor.test@gmail.com");
            if(search != null)
            {
                Console.WriteLine($"Registreret medlem med email: {search.Email} - {search.Navn}");
            }
            Console.WriteLine("\nMedlem test slut");

			// Booking
			Console.WriteLine("-----Booking start-----\n");

			// Opret en ny instans af BookingRepo
			BookingRepo bookingRepo = new BookingRepo();

			// Opret nogle testbookinger
			Booking booking1 = new Booking(1, medlem1, båd1, new DateTime(2024, 12, 25), true);
			Booking booking2 = new Booking(2, medlem2, båd2, new DateTime(2024, 12, 26, 12, 00, 00), true);

			// Create test
			bookingRepo.CreateBooking(booking1);
			bookingRepo.CreateBooking(booking2);
			Console.WriteLine("Create method test");
			Console.WriteLine($"Registrerede bookinger i Create test: {bookingRepo.bookinger.Count}");
			Console.WriteLine();

			// Read test
			Console.WriteLine("Read method test");
			var readBooking = bookingRepo.GetBooking(1);
			if (readBooking != null)
			{
				Console.WriteLine($"GetBooking registreret: {readBooking}");
			}
			Console.WriteLine();

			// Opret en søgedato
			DateTime searchDate = new DateTime(2024, 12, 25);

			// Brug SearchBookingByDate-metoden
			List<Booking> foundBookings = bookingRepo.SearchBookingByDate(searchDate);

			// Udskriv de fundne bookinger
			if (foundBookings.Count > 0)
			{
				Console.WriteLine($"Bookinger for {searchDate.ToString("yyyy-MM-dd")}:");
				foreach (var booking in foundBookings)
				{
					Console.WriteLine(booking.ToString());
				}
			}
			else
			{
				Console.WriteLine($"Ingen bookinger fundet for {searchDate.ToString("yyyy-MM-dd")}");
			}

			// Update af booking
			Console.WriteLine("Update method test");
			Console.WriteLine("Booking før Update");
			Console.WriteLine(booking1);
			bookingRepo.UpdateBooking(1, new Booking(1, medlem1, båd1, new DateTime(2024, 12, 25), false)); // Ændring
			Console.WriteLine("\nBooking efter Update");
			Console.WriteLine(booking1);
			Console.WriteLine();

			// Delete test
			Console.WriteLine("\nDelete method test");
			bookingRepo.DeleteBooking(1);
			Console.WriteLine($"Registrerede bookinger efter Delete Test: {bookingRepo.bookinger.Count}");
			Console.WriteLine();
			Console.WriteLine("-----Booking slut-----\n");
		}
    }
}

