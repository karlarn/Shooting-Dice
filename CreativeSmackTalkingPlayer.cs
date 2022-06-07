using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _tauntList = new List<string>{
            "HAHAH!",
            "You lose!",
            "Eat dirt."
        };

        private void RandomTaunt()
        {
            int randomNumber = new Random().Next(_tauntList.Count);
            Console.WriteLine($"{Name} says '{_tauntList[randomNumber]}'");
        }
        public override int Roll()
        {
            RandomTaunt();
            return base.Roll();
        }

    }
}