using System;

namespace guessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int secretNumber = 43;
            Console.WriteLine("What's the secret Number ?");
           int guess = int.Parse(Console.ReadLine());
            // Console.WriteLine(guess);
            while(guess != secretNumber ){
                Console.WriteLine("guess again ?");
                guess = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("You got it right!");
            
        }
    }
}
