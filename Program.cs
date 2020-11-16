using System;

namespace guessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            // var called secretNumber
           int secretNumber = new Random().Next(1, 101);
           int userTries = 0;
           //prompt the user to guess the secret number
            Console.WriteLine("What's the secret Number ?");
            //display  a prompt to guess
           int guess = int.Parse(Console.ReadLine());
            // useing a while loop to guess the secretNumber and a if/else to check how many times a user has guessed
            while(guess != secretNumber && userTries < 3){
                Console.WriteLine("guess again ?");
                 userTries++;
                 // tells the user the amount of time user has guessed 
                Console.WriteLine($"You have tired {userTries} times.");
                guess = int.Parse(Console.ReadLine());
               
                
              
            }
              if(userTries < 3 || guess == secretNumber){
                  Console.WriteLine("Awesome You got it right!");

              }else{
                  Console.WriteLine("Better Luck next time ");
              }
        }
    }
}
