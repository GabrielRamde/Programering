using System;
class MainClass {
    static void Main() {
        double sum = 0, input;
        double lowestNumber = 0;
        double biggestNumber = 0;
         Console.Write("Hur många tal ska matas in? ");
           int numbers = int.Parse(Console.ReadLine());
             for (int i = 1; i <= numbers; i++) {
         Console.Write($"Skriv in värde {i}: ");
           input = Convert.ToDouble(Console.ReadLine());
             sum =+ input;
               if (i == 1) {
                biggestNumber = input;
                lowestNumber = input;
            }
            if (input < lowestNumber)
                lowestNumber = input;
            if (input > biggestNumber)
                biggestNumber = input;
        }
        Console.WriteLine($"Medelvärdet är: {sum / numbers}");
        Console.WriteLine($"Största talet är: {biggestNumber}");
        Console.WriteLine($"Minsta talet är: {lowestNumber}");
    }
}
