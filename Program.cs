using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerScore = 0;
            int userScore = 0;
            string[] computerChoices = { "rock", "paper", "scissors" };
            string playAgain = "Y";

            while (playAgain == "Y")
            {
                string computerChoice = computerChoices[new Random().Next(0, computerChoices.Length)];
                Console.Write("Please enter your choice - rock, paper or scissors: ");
                string userChoice = Console.ReadLine();


                bool validChoice;
                if (userChoice != "paper" && userChoice != "rock" && userChoice != "scissors")
                {
                    validChoice = false;
                    Console.WriteLine("Please enter a valid choice.");

                }
                else
                {
                    validChoice = true;
                    Console.WriteLine("Computer choose: " + computerChoice);
                    Console.WriteLine("User choose: " + userChoice);
                }

                //declaring if clauses
                if (validChoice == true)
                {
                    if (computerChoice == userChoice)
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "It's a DRAW!");
                        PrintColorMessage(ConsoleColor.Magenta, "Computer " + computerScore + ":" + "User " + userScore);
                        PrintColorMessage(ConsoleColor.Cyan, "Play again? Y or N");
                        playAgain = Console.ReadLine().ToUpper();
                    }
                    else
                    {
                        if ((userChoice == "rock" && computerChoice != "scissors") || (userChoice == "paper" && computerChoice != "rock") || (userChoice == "scissors" && computerChoice != "paper"))
                        {
                            PrintColorMessage(ConsoleColor.Red, "You LOST!");
                            computerScore++;
                            PrintColorMessage(ConsoleColor.Magenta, "Computer " + computerScore + ":" + "User " + userScore);
                            PrintColorMessage(ConsoleColor.Cyan, "Play again? Y or N");
                            playAgain = Console.ReadLine().ToUpper();
                        }
                        else
                        {
                            PrintColorMessage(ConsoleColor.DarkGreen, "You WON!");
                            userScore++;
                            PrintColorMessage(ConsoleColor.Magenta, "Computer " + computerScore + ":" + "User " + userScore);
                            PrintColorMessage(ConsoleColor.Cyan, "Play again? Y or N");
                            playAgain = Console.ReadLine().ToUpper();
                        }
                    }
                }
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("FINAL SCORE IS: " + "COMPUTER: " + computerScore + " - " + "USER: " + userScore);
            Console.ResetColor();

            // Color
            void PrintColorMessage(ConsoleColor color, string message)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
                //end of program
            }
        }
    }
}
