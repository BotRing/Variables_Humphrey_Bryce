using System;

namespace Variables_LastName_FirstName
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber;
            bool isJumping = false, isRunning = false;
            float myFloat;
            favoriteNumber = 6;
            myFloat = 54.65f;
            const double finalGrade = 90.0;

            Console.WriteLine("Favorite #: " + favoriteNumber);
            Console.WriteLine("Jumping: " + isJumping);
            Console.WriteLine("Running: " + isRunning);
            Console.WriteLine("Random Floating #: " + myFloat);
            Console.WriteLine("Final Grade: " + finalGrade);
        }
    }
}
