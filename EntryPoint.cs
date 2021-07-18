using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WarriorsWars.Enum;


namespace WarriorsWars
{
    class EntryPoint
    {        
        static void Main(string[] args)
        {
            var random = new Random();

            var goodGuy = new Warrior("John", Faction.GoodGuy);
            var badGuy = new Warrior("Max", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (random.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else badGuy.Attack(goodGuy);

                Thread.Sleep(200);
            }
                        
        }
    }
}
