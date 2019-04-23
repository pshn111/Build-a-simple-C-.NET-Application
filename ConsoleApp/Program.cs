using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Shuonan";

            //change text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            //print info
            Console.WriteLine("{0}: Version{1} by {2}", appName, appVersion, appAuthor);
            //reset color
            Console.ResetColor();

            //ask user name 
            Console.WriteLine("What's your name?");

            //get user name 
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game.", userName);


            while (true)
            {
                //set answer
                //int answer = 6;

                //set a random answer
                Random random = new Random();

                int answer = random.Next(1, 10);

                //init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10.");

                // while the guess is not correct
                while (guess != answer)
                {
                    //get user inout
                    string userInput = Console.ReadLine();

                    //make sure user input a int
                    if (!int.TryParse(userInput, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number between 1 and 10!");
                        

                        //keep going
                        continue;
                    }
                    //convert str to int
                    guess = Int32.Parse(userInput);

                    //match guess to answer
                    if (guess != answer)
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                        
                    }

                }

                // print success message
                PrintColorMessage(ConsoleColor.Green, "You are CORRECT!!!");
                //change text color
                //Console.ForegroundColor = ConsoleColor.Green;
                //print info
                //Console.WriteLine("You are CORRECT!!!");
                //reset color
                //Console.ResetColor();

                //ask to play again
                Console.WriteLine("Play again? [Y/N]");
                //get user input
                string playAgain = Console.ReadLine().ToUpper();

                if(playAgain == "Y")
                {
                    continue;
                }              
                else
                {
                    return;
                }

            }
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;
            //print info
            Console.WriteLine(message);
            //reset color
            Console.ResetColor();
        }
    }
}
