// System namespace needed to use Console class.
using System;

// My collection of classes for this project
namespace Classes_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Creates new Greetings() under Greetings greetings
            Greetings greetings = new Greetings();
            // Creates greetings.Welcome()
            greetings.Welcome();

            // Asks the user for their name and clarifies it is for research purposes
            Console.WriteLine("What is your name, user? This is needed for research purposes");
            // Gives the user input and puts it under string userName
            string userName = Console.ReadLine();
            
            // Puts userName under greetings.Hello
            greetings.Hello(userName);

            // Tells the user instructions to continue the project
            Console.WriteLine("To continue the project...");
            // Stops suddenly and outputs a ...
            Console.WriteLine("...");
            // Tells user there's an error
            Console.WriteLine("ERROR ERROR");
            // Tells the user that the server is rebooting
            Console.WriteLine("Rebooting server...");
            // Tells the user an error has been discovered called {userName}.exe
            Console.WriteLine($"An error has been discovered. Error identified: {userName}.exe");
            // Tells the user it is eliminating the error
            Console.WriteLine("Eliminating error...");
            // Tells the user the error is eliminated and asks to restart the program
            Console.WriteLine("Error eliminated. Please restart the program, user...");
        }
    }
}
