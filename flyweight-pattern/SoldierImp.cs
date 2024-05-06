using System;

namespace flyweight_pattern
{
    public class Soldier : ISoldier
    {
        public void moveSoldier(int previousLocationX, int previousLocationY, int newLocationX, int newLocationY){
            Console.WriteLine(previousLocationX);
            Console.WriteLine(previousLocationY);
            Console.WriteLine(newLocationX);
            Console.WriteLine(newLocationY);
        }
    }
}