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
        }
    }
}

