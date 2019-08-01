using System;

// Namespace
namespace NumberGuesser
{
    // Main class
    class Program
    {
        // Entry point method
        static void Main(string[] args)
        {
            
            GetAppInfo();
            GreetUser();

           while (true) {
                // Create a new Random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                // Init guess var
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber) {

                    string value = Console.ReadLine();
                    // Make sure it is a number
                    if (!int.TryParse(value, out guess )){
                        PrintColorMessage(ConsoleColor.Red, "Input is not a number");
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(value);
                    // Match to correct
                    if( guess != correctNumber){
                         PrintColorMessage(ConsoleColor.Red, "Wrong number. Please try again ...." );
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are Correct ... ");

                Console.WriteLine("Play gain? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y"){
                    continue;
                }else if (answer == "N"){
                    return;
                }else {
                    return;
                }
           }
        }

        static void GetAppInfo() {
             // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Baya Benrachi";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;           
            // Write out app info
            Console.WriteLine("{0} : Version {1} by {2} ", appName, appVersion, appAuthor);
            // Reset text Color
            Console.ResetColor();  
        }

        static void GreetUser() {
            // Ask users name
            Console.WriteLine("What is your name?");
            // Get user name
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, Let's play a game.... ", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
             // Change text color
            Console.ForegroundColor = color;
            // Write out app info
            Console.WriteLine(message);
            // Reset text Color
            Console.ResetColor();
        }
    }
}
