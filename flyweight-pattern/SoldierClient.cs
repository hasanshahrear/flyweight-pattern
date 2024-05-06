using System;

namespace flyweight_pattern
{
    public class SoldierClient
    {
        private Soldier soldier = SoldierFactory.getSoldier();
        private int currentLocationX = 0;
        private int currentLocationY = 0;
        public void moveSoldier(int newLocationX, int newLocationY){
            soldier.moveSoldier(currentLocationX, currentLocationY, newLocationX, newLocationY);
            currentLocationX = newLocationX;
            currentLocationY = newLocationY;
            Console.WriteLine("Soldier moved to X:" + currentLocationX + " Y:" + currentLocationY);
        }
    }
}