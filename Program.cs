using System;

//DevBuild Lab : RPS Lab
//Author: Yosha Kunnummal
//Date: 10/31/2021
namespace RPSLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            string answer;
            while (playAgain)
            {                
                Rocky r = new Rocky();
                //Console.WriteLine(r.GetRPS());
                UserPlayer p = new UserPlayer();
                RPSEnum result = p.GetRPS();
                string choice1 = result.ToString();
                Console.WriteLine("You selected: " + result);

                Randa randa = new Randa();
                RPSEnum result1 = randa.GetRPS();
                Console.WriteLine("Randa selected: " + result1);
                string choice2 = result1.ToString();
                switch(choice1)
                {
                    case "Rock":
                        if(choice2=="Rock")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if(choice2 == "Paper")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "Paper":
                        if (choice2 == "Rock")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (choice2 == "Paper")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "Scissors":
                        if (choice2 == "Rock")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (choice2 == "Paper")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw");
                        }
                        break;
                }

                Console.WriteLine("Would you like to play again (y/n): ");
                answer = Console.ReadLine().ToLower();
                if(answer == "y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
