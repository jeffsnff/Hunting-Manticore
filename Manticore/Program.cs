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
        RoundInformation(manticore, consolas, round);
        GameRound(manticore, consolas, round);
        if (consolas.GetHealth() <= 0 && manticore.GetHealth() <= 0)
        {
          GameOver("Manticore has fallen, but Consolas was lost!");
          break;
        }
        if (consolas.GetHealth() <= 0)
        {
          GameOver("Consolas has fallen!");
          break;
        }
        if (manticore.GetHealth() <= 0)
        {
          GameOver("Manticore has been destoryed!");
          break;
        }
        round++;
      }
    }

    /// <summary>
    /// Ask user to choose a range to fire
    /// </summary>
    /// <returns>distance to calculate if a success</returns>
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

    /// <summary>
    /// One round of the game, calculating health of manticore, consolas and round
    /// </summary>
    /// <param name="manticore"></param>
    /// <param name="consolas"></param>
    /// <param name="round"></param>
    public static void GameRound(Manticore manticore, City consolas, int round)
    {
      Console.Write("Enter desired cannon range: ");
      int damage = Damage(round);
      manticore.updateHealth(round, Convert.ToInt32(Console.ReadLine()), damage);
      consolas.UpdateHealth();
    }

    public static void RoundInformation(Manticore manticore, City consolas, int round)
    {
      Console.Clear();
      Console.WriteLine($"Round: {round} City: {consolas} Manticore: {manticore}");
      Console.WriteLine($"The cannon is expected to deal {Damage(round)} damage this round.");
    }
    /// <summary>
    /// Calculates amount of damage to do
    /// </summary>
    /// <param name="round"></param>
    /// <returns>Damage output</returns>
    public static int Damage(int round)
    {
      if (round % 3 == 0 && round % 5 == 0)
      {
        return 10;
      }
      if (round % 3 == 0 || round % 5 == 0)
      {
        return 3;
      }
      return 1;
    }

    public static void GameOver(string message)
    {
      Console.WriteLine(message);
      Console.ReadKey();
    }
  }
}