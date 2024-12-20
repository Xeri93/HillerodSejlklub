namespace HillerodSejlklub
{
    public class HellerodSejlklub
    {
        static void Main()
        {
            //Create ny båd
            Båd båd = new Båd(1, "Armadillo", "Sejlskib", "xdd", "123"
                , "mega god motor", "5m x 4.20m x 6.9m", "2000", false);
            BådRepo bådrepo = new BådRepo();
            bådrepo.CreateBåd(båd);
            Console.WriteLine(bådrepo.ReadBåd(1));

            //Create ny Vedligeholdelseslog
            VedligeholdelseslogRepo logRepo = new VedligeholdelseslogRepo();
            Vedligeholdelseslog log = new Vedligeholdelseslog(1, 1, DateTime.Now, "Motorservice udført", "Henrik Hansen");
            logRepo.CreateLog(log);
            Console.WriteLine(logRepo.GetLog(1));

            //Create ny blog og begivenhed
            Console.WriteLine();
            Console.WriteLine("Begivenhed start\n");

            Blog blog = new Blog(1, "Hillerød sejlklub");
            DateTime begivenhedDato1 = new DateTime(2024, 11, 18, 8, 30, 0);
            DateTime begivenhedDato2 = new DateTime(2024, 11, 19, 9, 0, 0);
            Begivenhed begivenhed1 = new Begivenhed(1, begivenhedDato1, "Sport bådsejlads");
            Begivenhed begivenhed2 = new Begivenhed(2, begivenhedDato2, "Træning");

            // Add begivenhed til blog
            blog.AddBegivenhed(begivenhed1);
            blog.AddBegivenhed(begivenhed2);

            foreach (var begivenhed in blog.begivenhedDict.Values)
            {
                Console.WriteLine(begivenhed.ToString());
            }
            Console.WriteLine("\nBegivenhed slut");

            // Booking
            Console.WriteLine();
            Console.WriteLine("Booking start\n");

            Medlem medlem = new Medlem(1, "Jens", "Jens123@gmail.com", "78609520", false);
            DateTime bookingDato = new DateTime(2024, 12, 18, 14, 30, 0);
            Booking booking1 = new Booking(1, medlem, båd, bookingDato, true);
            BookingRepo bookingRepo = new BookingRepo();
            bookingRepo.AddBooking(booking1);
            Console.WriteLine(booking1.ToString());



            Console.WriteLine("\nBooking slut");

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
        }
    }
}

