using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "My mom plays better!";

        public override int Roll()
        {
            Console.WriteLine($"{Name} says '{Taunt}'");
            return base.Roll();
        }

        
    }
}