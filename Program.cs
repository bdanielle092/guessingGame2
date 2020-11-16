using System;

namespace guessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            // we are assigning the variables. int in the type. secrestNumber is the variable and we are assigning it Random().Next(1, 100)
            // secretNumber  = a random number between 1 - 100 
            //.Next Returns a non-negative random integer.
           int secretNumber = new Random().Next(1, 101);
           int difficultyLevel = 0;
           int userTries = 0;
        // used a switch case to have user pick a difficulty level 
        //while difficultyLevel == 0 then they can pick a level
         while (difficultyLevel == 0)
         {
             Console.WriteLine("Select a difficulty:");
             Console.WriteLine("1) Easy - eight guesses");
             Console.WriteLine("2) Medium - six guesses");
             Console.WriteLine("3) Hard - four guesses");
             Console.WriteLine("4) Cheater - infinite");
// this allows the user to pick a level
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
            Console.WriteLine("Guess the secret Number ?");
            //display a prompt to the user to guess a number 
           int usersGuess = int.Parse(Console.ReadLine());
            // using a while loop to guess the secretNumber and the amount to time a user has guesses
            while(usersGuess != secretNumber && userTries != 1){

               
                //if else statement for guessing if the number is  to low or to high
                if(usersGuess < secretNumber){
                    Console.WriteLine("");
                    Console.WriteLine("You guess is to low");
                }else{
                    Console.WriteLine("");
                    Console.WriteLine("You guess is to high");
                }
                //subtracts the number of times a user has tried
                 userTries--;
                 // tells the user the amount of times they have left to guess
                Console.WriteLine($"You have {userTries} guesses left.");
                //allow the user to guess
                usersGuess = int.Parse(Console.ReadLine());
               
            }
            //if else statement on weather they got it right or to wrong
              if(userTries != 1 || usersGuess == secretNumber){
                  Console.WriteLine("Awesome You got it right!");

              }else{
                  Console.WriteLine("Better Luck next time ");
              }
        }
    }
}
