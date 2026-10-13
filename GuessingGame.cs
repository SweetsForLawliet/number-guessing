using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        GuessingGameClass.NumberGuessing();
    }
}
public class GuessingGameClass
{
    public static void NumberGuessing()
    {

        Random random = new Random();
        var secret = random.Next(1, 11);

        Console.WriteLine("=== NUMBER GUESSING GAME ===");
        Console.WriteLine("Guess a number between 1 and 10 \n You have 3 tries!");

        bool won = false;

        for (var attempt = 1; attempt <= 3; attempt++)
        {
            Console.Write("Attempt " + attempt + " Enter your guess: ");
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secret)
            {
                Console.WriteLine("Congratulations! You guessed the secret number!");
                won = true;
                break;
            }
            else if (guess < secret)
            {
                Console.WriteLine("Too low! Try again!");
            }
            else
            {
                Console.WriteLine("Too high! Try again!");
            }
        }
        if (!won)
        {
            Console.WriteLine("Game over! You've run out of tries. \nThe secret number is " + secret + ".");
        }
    }
}
