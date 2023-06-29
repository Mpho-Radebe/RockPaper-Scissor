using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Console.WriteLine("player please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hey "+ name + " Welcome to GirlCoders Gaming zone");
            Console.WriteLine("Choose either Rock, Paper, or Scissors?");
            string userChoice = "";

            while (true)
            {
                userChoice = Console.ReadLine().ToLower();

                if (userChoice == "rock" || userChoice == "paper" || userChoice == "scissors")
                    break;

                Console.WriteLine("Invalid choice. Please choose either rock, paper, or scissors.");
            }

            // Generate the computer's choice randomly
            Random random = new Random();
            int computerChoice = random.Next(1, 4); // Generates a random number from 1 to 3

            string computerChoiceString = "";
            switch (computerChoice)
            {
                case 1:
                    computerChoiceString = "rock";
                    break;
                case 2:
                    computerChoiceString = "paper";
                    break;
                case 3:
                    computerChoiceString = "scissors";
                    break;
            }

            Console.WriteLine("You chose: " + userChoice);
            Console.WriteLine("Computer chose: " + computerChoiceString);

            // Compare the choices to determine the winner
            if (userChoice == computerChoiceString)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (userChoice == "rock")
            {
                if (computerChoiceString == "scissors")
                    Console.WriteLine("You win! Rock wins against scissors.");
                else
                    Console.WriteLine("Computer wins!");
            }
            else if (userChoice == "paper")
            {
                if (computerChoiceString == "rock")
                    Console.WriteLine("You win! Paper wins against rock.");
                else
                    Console.WriteLine("Computer wins!");
            }
            else if (userChoice == "scissors")
            {
                if (computerChoiceString == "paper")
                    Console.WriteLine("You win! Scissors win against paper.");
                else
                    Console.WriteLine("Computer wins!");
            }

            // Ask if the user wants to play again
            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainChoice = Console.ReadLine().ToLower();

            if (playAgainChoice != "yes")
                playAgain = false;

            Console.Clear();
        }

        Console.WriteLine("Thank you for playing!");
        Console.ReadLine();
    }
}

