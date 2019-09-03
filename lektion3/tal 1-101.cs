using System;

class MainClass {
  public static void Main (string[] args) {
   Console.WriteLine("Skriv ett tal mellan 0 och 100");
     int i = int.Parse(Console.ReadLine());
       while (i < 101) 
     {
     
     i++;
     Console.WriteLine(i);


   }
  }
}
