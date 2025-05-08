using System;
using ArithmeticFunctions; 
 
namespace ProgramClass  
{
  public class Program {
    static void Main(String[] args) {
      Arithmetic a = new Arithmetic();
      Random rnd = new Random();
      string exit = "";

      while (exit != "exit") {
          
        int x = rnd.Next(0,100);
        int y = rnd.Next(0,100); 
        Console.Write($"What is {x} + {y} equal to : ");
        int answer = int.Parse(Console.ReadLine());
        bool correct = a.Answer(x, y, answer);
        Console.WriteLine($"That is {(correct ? "Correct" : "Wrong")} the answer was {x + y}"); // Used AI and C# docs  
        Console.Write("If you want to continue click enter else enter exit No Caps ");
        exit = Console.ReadLine();
      
      }
    }
  }
    
}
