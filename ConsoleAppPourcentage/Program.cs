using System;
using System.Threading;

namespace ConsoleAppPourcentage
{
  internal class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i <= 100; i++)
      {
        Console.Write($"\rProgression : {i}%");
        Thread.Sleep(50);
      }

      Console.WriteLine("\nOpération terminée !");
      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
