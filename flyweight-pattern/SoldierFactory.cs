using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flyweight_pattern
{
    public class SoldierFactory
    {
        private static Soldier SOLDIER;
        public static Soldier getSoldier(){
            if(SOLDIER == null){
                SOLDIER = new Soldier();
            }
            return SOLDIER;
        }
    }
}