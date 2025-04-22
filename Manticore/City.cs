using System;

namespace Manticore
{
  internal class City
  {
    private int initialHealth = 15;
    private int actualHealth = 15;

    public City() { }

    public void UpdateHealth()
    {
      actualHealth = actualHealth - 1;
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