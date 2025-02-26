using System;

namespace Variables_LastName_FirstName
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber; // Declares an interger to store a favorite number
            bool isJumping = false, isRunning = false;  // Booleans initialized to false for jumping and running
            float myFloat;  // Declared random float variable
            favoriteNumber = 6; // Assigning the favoriteNumber to 6
            myFloat = 54.65f;   // Assigning myFloat to 54.65
            const double finalGrade = 90.0; // Initializing constant finalGrade to 90

            // Prints all variables to console
            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
