using System;

namespace Manticore
{
  internal class Manticore
  {
    int health = 10;
    int range = 0;

    public Manticore(int range)
    {
      this.range = range;
    }

    public override string ToString()
    {
      return $"Manticore: Health: {this.health} Range: {this.range}";
    }
  }
}