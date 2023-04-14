// System namespace needed to use Console class.
using System;
// System.Collections.Generic namespace needed to use Console class.
using System.Collections.Generic;
// System.Text namespace needed to use Console class.
using System.Text;

// My collection of classes for this project.
namespace Classes_Sadler_Madison
{
    //Main class for the greetings
    class Greetings
    {
        // The Main methods are executed when the application starts
        // This method prints a welcome message to the user
        public void Welcome()
        {
            // Welcomes the user and introduces itself
            Console.WriteLine("Welcome, User. My name is NAER, which stands for Not An Evil Robot, but call me NAER for short.");
        }

        // This method prints a hello message to the user
        public void Hello(string name)
        {
            // Clarifies that the user's name is {name} and thanks the user for joining the research program and that it appreciates their support
            Console.WriteLine($"Your name is {name}, correct User? Alright. Thank you for joining our research program into Artificial Intelligence. We appreciate your support and assistance.");
        }
    }
}
