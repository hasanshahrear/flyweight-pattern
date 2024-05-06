using System;

namespace flyweight_pattern
{
    public class Soldier : ISoldier
    {
        public void moveSoldier(int previousLocationX, int previousLocationY, int newLocationX, int newLocationY){
            Console.WriteLine("Solder Prev Location X: "+ previousLocationX);
            Console.WriteLine("Solder Prev Location Y: "+ previousLocationY);
            Console.WriteLine("Solder New Location X: "+ newLocationX);
            Console.WriteLine("Solder New Location Y: "+ newLocationY);
        }
    }
}