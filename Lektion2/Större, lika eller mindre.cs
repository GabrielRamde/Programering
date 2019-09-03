using System;

class MainClass {
  public static void Main (string[] args) {
   Console.Write("Skriv ett tal: ");
     int tal = int.Parse(Console.ReadLine());
       if (tal > 10)
   Console.WriteLine("Talet är större än tio");
     if (tal < 10)
   Console.WriteLine("Talet är mindre än tio");
     if (tal == 10)
   Console.WriteLine("Talet är lika med tio");
    }
}
