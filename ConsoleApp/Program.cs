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
        }
    }
}
