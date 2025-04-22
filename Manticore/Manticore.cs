using System;

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

    public void updateHealth(int round, int distance)
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
        if (round % 3 == 0 && round % 5 == 0)
        {
          actualHealth = actualHealth - 10;
          return;
        }
        if (round % 3 == 0 || round % 5 == 0)
        {
          actualHealth = actualHealth - 3;
          return;
        }
        actualHealth = actualHealth - 1;
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