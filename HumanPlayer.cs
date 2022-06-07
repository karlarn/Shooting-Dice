using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write($"{Name}, what freakin number do you want?");
            int freakinNumber = 0;
            try
            {
                freakinNumber = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("That wasn't a number, your number is 0.");
            }
            return freakinNumber;
        }

    }
}