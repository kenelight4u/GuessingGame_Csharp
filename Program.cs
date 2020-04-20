using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("WELCOME TO THE KENELIGHT4U GAME HOUSE.");
            Console.WriteLine("WE HAVE THREE LEVELS: EASY, MEDIUM AND HARD. MAY I KNOW THE LEVEL YOU WANT TO PLAY?");

            Console.WriteLine("\n");
            Console.WriteLine("Type in EASY or MEDIUM or HARD depending on the LEVEL you want to Play");

            string level = Console.ReadLine().ToUpper();

            if (level == "EASY" ) 
            {
                Random random = new Random();

                int returnValue = random.Next(1, 10);  //generates number between 1 and 10 randomly

                int Guess = 0; int maxGuess = 6;

                Console.WriteLine("I am thinking of a number between 1 - 10. Can you guess what it is? Remember, you have only SIX Guesses to get it Right");

                for (int i = 0; i <= 5; i++)
                {
                    maxGuess--;

                    Console.WriteLine("\n");
                    Console.Write("Guess: ");

                    string notNumber = Console.ReadLine(); //Get String from User

                    if (!int.TryParse(notNumber, out Guess)) //Try to parse the string as an integer
                    {
                    Console.WriteLine("That's not a Number! Your Guess remains " + maxGuess );
                    }
                    else 
                    {
                        if (Guess != returnValue)
                        {
                            Console.WriteLine("That was Wrong!!! Your Guess remains " + maxGuess );
                        }
                        else
                        {
                            Console.WriteLine("Yes!!! You got it Right. The answer is " + returnValue);
                            break;
                        }
                    }   

                    if (i == 5)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("GAME OVER!!! The answer is " + returnValue);
                    } 

                }
            }
            else if (level == "MEDIUM")
            {
                Random random = new Random();

                int returnValue = random.Next(1, 20); //generates number between 1 and 20 randomly

                int Guess = 0; int maxGuess = 4;

                Console.WriteLine("I am thinking of a number between 1 - 20. Can you guess what it is? Remember, you have only FOUR Guesses to get it Right");

                for (int i = 0; i <= 3; i++)
                {
                    maxGuess--;

                    Console.WriteLine("\n");
                    Console.Write("Guess: ");

                    string notNumber = Console.ReadLine(); //Get String from User

                    if (!int.TryParse(notNumber, out Guess)) //Try to parse the string as an integer
                    {
                    Console.WriteLine("That's not a Number! Your Guess remains " + maxGuess );
                    // continue;
                    }
                    else
                    {
                        if (Guess != returnValue)
                        {
                            Console.WriteLine("That was Wrong!!! Your Guess remains " + maxGuess );
                        }
                        else
                        {
                            Console.WriteLine("Yes!!! You got it Right. The answer is " + returnValue);
                            break;
                        }
                    }
                    
                    if (i == 3)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("GAME OVER!!! The answer is " + returnValue);
                    } 
                
                }
            }
            else if (level == "HARD")
            {
                Random random = new Random();

                int returnValue = random.Next(1, 50); //generates number between 1 and 50 randomly

                int Guess = 0; int maxGuess = 3;

                Console.WriteLine("I am thinking of a number between 1 - 50. Can you guess what it is? Remember, you have only THREE Guesses to get it Right");

                for (int i = 0; i <= 2; i++)
                {
                    maxGuess--;

                    Console.WriteLine("\n");
                    Console.Write("Guess: ");

                    string notNumber = Console.ReadLine(); //Get String from User

                    if (!int.TryParse(notNumber, out Guess)) //Try to parse the string as an integer
                    {
                    Console.WriteLine("That's not a Number! Your Guess remains " + maxGuess );
                    }
                    else
                    {
                      if (Guess != returnValue)
                        {
                            Console.WriteLine("That was Wrong!!! Your Guess remains " + maxGuess );
                        }
                        else
                        {
                            Console.WriteLine("Yes!!! You got it Right. The answer is " + returnValue);
                            break;
                        }  
                    }
                    
                    if (i == 2)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("GAME OVER!!! The answer is " + returnValue);
                    } 
                
                } 
            }
            else
            {
                Console.WriteLine("NO SUCH LEVEL");
            }
            

        }
    }
}
