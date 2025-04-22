using System;
using System.Data;

namespace Manticore
{
  internal class Manticore
  {
    int initialHealth = 10;
    int actualHealth = 10;
    int range = 0;

    public Manticore(int range)
    {
      this.range = range;
    }

    public void updateHealth(int round, int distance, int damage)
    {
      if (distance < range)
      {
        Console.WriteLine("The round FELL SHORT of the target!");
        return;
      }
      if (distance > range)
      {
        Console.WriteLine("The round OVERSHOT the target!");
        return;
      }
      if (distance == range)
      {
        switch (damage)
        {
          case 10:
            actualHealth = actualHealth - 10;
            break;
          case 3:
            actualHealth = actualHealth - 3;
            break;
          default:
            actualHealth = actualHealth - 1;
            break;
        }
      }
    }

    public int GetHealth()
    {
      return actualHealth;
    }

    public override string ToString()
    {
      return $"{actualHealth}/{initialHealth}";
    }
  }
}