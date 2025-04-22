using System;

namespace Manticore
{
  internal class Program
  {
    static void Main(string[] args)
    {

      int distance = ChooseDistance();

      Manticore manticore = new Manticore(distance);
      Console.WriteLine(manticore);
    }

    public static int ChooseDistance()
    {
      while (true)
      {
        Console.Write("Player 1 choose a distance for the airship between 1 and 100: ");
        int distance = Convert.ToInt32(Console.ReadLine());
        if (distance > 100 || distance < 1)
        {
          Console.WriteLine("Invalid distance.");
          continue;
        }
        return distance;
      }
    }
  }
}