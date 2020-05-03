using System;
using System.Collections.Generic;

class MainClass 
{
  public static List<studentas> studentai=new List<studentas>();

  public static void Main (string[] args) 
  { string vardas;
  string pavarde;
  int egz;

    Console.WriteLine("Iveskite varda");
    vardas=Console.ReadLine();
    Console.WriteLine("Įveskite pavarde");
    pavarde=Console.ReadLine();
    Console.WriteLine("Įveskite egzamino bala");
    egz=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Įveskite nd bala(-us)");
    
    string nus = Console.ReadLine();
    string[] tarp = nus.Split(' ');
    List<int> nd=new List<int>(Array.ConvertAll(tarp, int.Parse));

     
    studentai.Add(new studentas(vardas, pavarde, egz, nd));
    Console.WriteLine("{0} {1, 10} {2, 10} {3, 10}","Vardas", "Pavarde", "Vidurkis", "Mediana");
    Console.WriteLine("-------------------------------------------");
    foreach (var sk in studentai)
    {
      Console.WriteLine("{0} {1, 10} {2, 10} {3, 10}", sk.vardas, sk.pavarde, sk.vid.ToString("#.##"), sk.med);
    }
    
    
  }
}