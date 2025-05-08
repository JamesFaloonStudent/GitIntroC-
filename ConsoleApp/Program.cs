using System;
using ArithmeticFunctions; 
 
namespace ProgramClass  
{
  public class Program {
    static void Main(String[] args) {
      Arithmetic a = new Arithmetic();
      int x = 5;
      int y = 4; 
      Console.Write($"What is {x} + {y} equal to : ");
      int answer = int.Parse(Console.ReadLine());
      bool correct = a.Answer(x, y, answer);
      Console.WriteLine($"That is {(correct ? "Correct" : "Wrong")} the answer was {x + y}"); // Used AI and C# docs  
    }
  }
    
}
