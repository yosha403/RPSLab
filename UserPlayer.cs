using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class UserPlayer: Player
    {
        public UserPlayer()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
        }

        //we want our user to select R P orS
        //and if we get anything else, ask for an RPS value again
        public override RPSEnum GetRPS()
        {
            Console.WriteLine("Please select rock, paper or scissor(r, p or s for short)");
            string answer = Console.ReadLine();

            switch(answer)
            {
                case "rock":
                    return RPSEnum.Rock;
                case "r":
                    return RPSEnum.Rock;
                case "paper":
                    return RPSEnum.Paper;
                case "p":
                    return RPSEnum.Paper;
                case "scissors":
                    return RPSEnum.Scissors;
                case "s":
                    return RPSEnum.Scissors;
                default:
                    Console.WriteLine("I am sorry I don't understand your input.Please try again");
                    return GetRPS();

            }
        }
    }
}
