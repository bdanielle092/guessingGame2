using System;

namespace guessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int secretNumber = 43;
           int Usertry = 1;
            Console.WriteLine("What's the secret Number ?");
           int guess = int.Parse(Console.ReadLine());
            
            while(guess != secretNumber && Usertry < 4){
                Console.WriteLine("guess again ?");
                guess = int.Parse(Console.ReadLine());
                Usertry++;
            }
                Console.WriteLine("You got it right!");
            
        }
    }
}
