namespace HillerodSejlklub
{
    public class HellerodSejlklub
    {
        static void Main()
        {
            //Create ny båd - Max
            Console.WriteLine("** båd test start **");

            Båd båd = new Båd(1, "Armadillo", "Sejlskib", "xdd", "123"
                , "mega god motor", "5m x 4.20m x 6.9m", "2000", false);
            BådRepo bådrepo = new BådRepo();
            bådrepo.CreateBåd(båd);
            Console.WriteLine(bådrepo.ReadBåd(1));
            bådrepo.UpdateVedligeholdelseslog(1, "Der er noget galt med denne båd", true);
            Console.WriteLine(bådrepo.PrintVedligeholdelseslog(1));

            Console.WriteLine("** båd test slut **");


            //Create ny blog og begivenhed - Simon
            Console.WriteLine();
            Console.WriteLine("Begivenhed start");

            Blog blog = new Blog(1, "Sejlads nyheder");
            Begivenhed begivenhed1 = new Begivenhed(blog, 1, "Sport bådsejlads");
            Begivenhed begivenhed2 = new Begivenhed(blog, 2, "Træning");
            
            // Add begivenhed til blog
            blog.AddBegivenhed(begivenhed1);
            blog.AddBegivenhed(begivenhed2);

            foreach (var begivenhed in blog.begivenhedDict.Values)
            {
                Console.WriteLine(begivenhed.ToString());
            }

            Console.WriteLine("Begivenhed slut");

            Console.WriteLine();
            Console.WriteLine("Booking start");
            Medlem medlem = new Medlem(1, "Jens", "Jens123@gmail.com", "78609520", false);
			DateTime bookingDato = new DateTime(2024, 12, 18, 14, 30, 0);
			Booking booking1 = new Booking(1, medlem, båd, bookingDato, true);
            BookingRepo bookingRepo = new BookingRepo();
            bookingRepo.AddBooking(booking1);
            Console.WriteLine(booking1.ToString());
			Console.WriteLine("Booking slut");
        }
    }
}

