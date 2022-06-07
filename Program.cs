using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            SmackTalkingPlayer player1 = new SmackTalkingPlayer();
            player1.Name = "Bob";

            OneHigherPlayer player2 = new OneHigherPlayer();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";

            player3.Play(player2);

            Console.WriteLine("-------------------");

            HumanPlayer player4 = new HumanPlayer();
            player4.Name = "Seanathon";

            player4.Play(player3);

            Console.WriteLine("-------------------");

            Player player5 = new CreativeSmackTalkingPlayer();
            player5.Name = "Karl";

            player5.Play(player4);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            Player sore2 = new SoreLoserUpperHalfPlayer();
            sore2.Name = "Karen";

            Player sore1 = new SoreLoserPlayer();
            sore1.Name = "Chad";

            Player upper = new UpperHalfPlayer();
            upper.Name = "Susan";

            List<Player> players = new List<Player>() {
                player1, player2, player3, player4, player5, large, sore1, sore2, upper
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players
            .OrderBy(p => randomNumberGenerator.Next())
            .ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                try
                {
                    player1.Play(player2);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); 
                }
                
            }
        }
    }
}