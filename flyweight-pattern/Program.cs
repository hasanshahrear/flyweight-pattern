using System;

namespace flyweight_pattern
{
  class Program
  {
    static void Main(string[] args)
    {
      SoldierClient[] warSoldiers  = {
        new SoldierClient(),
        new SoldierClient(),
        new SoldierClient(),
        new SoldierClient(),
        new SoldierClient()
      };

      warSoldiers[0].moveSoldier(17, 2112);
      warSoldiers[1].moveSoldier(137, 112);
    }
  }
}