using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flyweight_pattern
{
    public class SoldierClient
    {
        private Soldier soldier = SoldierFactory.getSoldier();
        private int currentLocationX = 0;
        private int currentLocationY = 0;
        private int newLocationX = 0;
        private int newLocationY = 0;
    }
}