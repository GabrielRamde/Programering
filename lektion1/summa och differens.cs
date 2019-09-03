using System;

class MainClass {
  public static void Main (string[] args) 
  
  {
   
   Console.WriteLine ("Skriv ett heltal: ");
     string strNr1 = Console.ReadLine();
       int tal1 = int.Parse(strNr1);
   Console.WriteLine ("Skriv ett till heltal: ");    string strNr2 = Console.ReadLine();
       int tal2 = int.Parse(strNr2);  
         Console.WriteLine (tal1 + tal2);
     
     {
   
   Console.WriteLine ("Skriv ett heltal: ");
     string strNr4 = Console.ReadLine();
       int tal3 = int.Parse(strNr4);
   Console.WriteLine ("Skriv ett till heltal: ");    string strNr5 = Console.ReadLine();
     int tal4 = int.Parse(strNr5);  
       Console.WriteLine (tal3 - tal4);
     
     }
   }
}
