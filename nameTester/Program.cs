using System;
using SplashKitSDK;

public enum MenuOption
{ TestName, GuessThatNumber, Quit }

public class Program
{
    public static void RunGuessThatNumber()
    {
        int target;
        int guess;
        int lowestGuess = 1;
        int highestGuess = 100;

        target = new Random().Next(100) + 1;
        Console.WriteLine("this is target " + target);
        Console.WriteLine("Guess a number between 1 - 100");
        guess = Convert.ToInt32(Console.ReadLine());

        while (guess != target)
        {
            if (guess < target)
            {
                Console.WriteLine("Guess is lower than target");
                lowestGuess = guess;
                guess = ReadGuess(lowestGuess, highestGuess);
            }
            else if (guess > target)
            {
                Console.WriteLine("Guess is higher than target");
                highestGuess = guess;
                guess = ReadGuess(lowestGuess, highestGuess);
            }

        }
        Console.WriteLine("You've guessed right!");


    }
    private static int ReadGuess(int min, int max)
    {
        int numbernumber;

        do
        {
            Console.WriteLine("Enter a number in between the min and max values : ");
            try
            {
                numbernumber = Convert.ToInt32(Console.ReadLine());

            }
            catch {
                Console.WriteLine("Write what is requested of you please");
                numbernumber = -1;
            }



        }
        while (numbernumber < min && numbernumber > max);

        return numbernumber;
    }
    public static void TestName()
    {
        string name;
        Console.WriteLine("Enter name please:");
        name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
        if (name.ToLower() == "nick")
        {
            Console.WriteLine("Hello my creator");
        }
        else if (name.ToLower() == "par")
        {
            Console.WriteLine("Hello you dinky");
        }
    }

    public static void Main()
    {
        MenuOption userSelection;

        userSelection = ReadingtheUserOption();

        do
        {
            switch (userSelection)
            {
                case MenuOption.TestName:
                    TestName();
                    break;
                case MenuOption.GuessThatNumber:
                    RunGuessThatNumber();
                    break;
                case MenuOption.Quit:
                    Console.WriteLine("Quitting time");
                    break;
            }
        }
        while (userSelection != MenuOption.Quit);


    }

    public static MenuOption ReadingtheUserOption()
    {
        int option;
        string options;


        do
        {
            Console.Write("Choose a number from 1-3 :");

            options = Console.ReadLine();

            //failsafe if user does not choose the correct number
            try
            {
                option = Convert.ToInt32(options);
            }
            catch
            {
                Console.WriteLine("Please write the correct number");
                option = -1;
            }

        }
        while (option < 1 && option > 3);

        return (MenuOption)(option - 1);
    }





}


