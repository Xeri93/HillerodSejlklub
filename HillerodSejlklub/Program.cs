// See https://aka.ms/new-console-template for more information
using HillerodSejlklub;

Console.WriteLine("Hello, World!");
Console.WriteLine("test");
Console.WriteLine("test max");
Console.WriteLine("123");
Console.WriteLine("try again");
Console.WriteLine("54321");

Medlem medlem = new Medlem(1,"Tobias","tobias.mejsebo@gmail.com","29708324",false);
Medlem medlem2 = new Medlem(2, "Johan", "tobias.mejsebo@gmail.com", "29708324", false);
Medlem medlem3 = new Medlem(3, "Henrik", "tobias.mejsebo@gmail.com", "29708324", false);

MedlemRepo medlemRepo = new MedlemRepo();

medlemRepo.CreateMedlem(medlem);
medlemRepo.CreateMedlem(medlem2);
medlemRepo.CreateMedlem(medlem3);

Console.WriteLine(medlemRepo.GetMedlem(3));