using System;

namespace Manticore
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int round = 1;
      City consolas = new City();
      Manticore manticore = new Manticore(ChooseDistance());

      while (true)
      {
        Console.WriteLine($"Round: {round} City: {consolas} Manticore: {manticore}");
        GameRound(manticore, consolas, round);
        if (consolas.GetHealth() <= 0)
        {
          Console.WriteLine("Consolas has fallen!");
          Console.ReadKey();
          break;
        }
        if (manticore.GetHealth() <= 0)
        {
          Console.WriteLine("Manticore has been destoryed!");
          Console.ReadKey();
          break;
        }
        round++;
      }
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

    public static void GameRound(Manticore manticore, City consolas, int round)
    {
      Console.Write("Enter desired cannon range: ");
      manticore.updateHealth(round, Convert.ToInt32(Console.ReadLine()));
      consolas.UpdateHealth();
    }
  }
}