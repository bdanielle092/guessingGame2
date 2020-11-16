using System;

namespace guessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            // var called secretNumber which is a number between 1 - 100
           int secretNumber = new Random().Next(1, 101);
           // difficulty level
           int difficultyLevel = 0;
           // userTries
           int userTries = 0;
// used a switch to have user pick a difficulty level 
         while (difficultyLevel == 0)
         {
             Console.WriteLine("Select a difficulty:");
             Console.WriteLine("1) Easy - eight guesses");
             Console.WriteLine("2) Medium - six guesses");
             Console.WriteLine("3) Hard - four guesses");
             Console.WriteLine("4) Cheater - infinite");

             difficultyLevel = int.Parse(Console.ReadLine());
             switch (difficultyLevel)
             {
                 case 1:
                 userTries = 8;
                 break;
                 case 2:
                 userTries = 6;
                 break;
                 case 3: 
                 userTries = 4;
                 break;
                 case 4:
                 userTries = int.MaxValue;
                 break;
                 default:
                 Console.WriteLine("Must select 1, 2, 3 or 4");
                 difficultyLevel = int.Parse(Console.ReadLine());
                 break;
             }

         }

           //prompt the user to guess the secret number
            Console.WriteLine("What's the secret Number ?");
            //display  a prompt to guess
           int guess = int.Parse(Console.ReadLine());
            // useing a while loop to guess the secretNumber and the amount to time a user has guesseds
            while(guess != secretNumber && userTries != 1){

                Console.WriteLine("guess again ?");
                //if else statement for guessing to low or high
                if(guess < secretNumber){
                    Console.WriteLine("");
                    Console.WriteLine("You guess is to low");
                }else{
                    Console.WriteLine("");
                    Console.WriteLine("You guess is to high");
                }
                 userTries--;
                 // tells the user the amount of time user has guessed 
                Console.WriteLine($"You have tired {userTries} times.");
                //allow the user to guess
                guess = int.Parse(Console.ReadLine());
               
            }
            //if else statement on weather they got it right or to wrong
              if(userTries != 1 || guess == secretNumber){
                  Console.WriteLine("Awesome You got it right!");

              }else{
                  Console.WriteLine("Better Luck next time ");
              }
        }
    }
}
