using System;
using SplashKitSDK;
using System.Collections.Generic;

public class Program
{
    public enum UserOption
    {
        NewValue, Sum, Print, Quit
    }
    private static List<double> _values = new List<double>();
    public static int ReadInteger(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }

    }

    public static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        while (true)
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid integer");
            }
        }

    }

    public static void AddValueToList()
    {
        int catcher;
        Console.WriteLine("Enter 1 if you would like to set the capacity of your list and 2 if you just want to add something in it");
        catcher = Convert.ToInt32(Console.ReadLine());
        if (catcher == 1)
        {
            int numberOfValues = ReadInteger($"Give me the size of your array: ");

            _values.Capacity = numberOfValues;

            for (int i = 0; i < numberOfValues; i++)
            {
                _values.Add(ReadDouble($"Please add a value here: "));

            }
            Main();

        }
        else
        {
            _values.Add(ReadDouble($"Please add a value here: "));
            Main();
        }


    }

    public static void Print()
    {
        foreach (double i in _values)
        {
            Console.WriteLine(i);
        }
    }
    public static void Sum()
    {
        double sum = 0;
        foreach (double i in _values)
        {
            sum += i;
        }
        Console.WriteLine("Total of Sum " + sum);
    }

    public static UserOption ReadUserOption()
    {
        Console.WriteLine("Enter 0 to add value");
        Console.WriteLine("Enter 1 to add a sum all value");
        Console.WriteLine("Enter 2 to print a summary of all the values");
        Console.WriteLine("Enter 3 to quit");

        int option = 3;
        Int32.TryParse(Console.ReadLine(), out option);

        return (UserOption)option;
    }
    public static void Main()
    {
        UserOption UserSelect;

        UserSelect = ReadUserOption();

        Console.WriteLine("User selected to " + UserSelect);
        switch (UserSelect)
        {
            case UserOption.NewValue:
                AddValueToList();
                break;
            case UserOption.Sum:
                Sum();
                break;
            case UserOption.Print:
                Print();
                break;
            case UserOption.Quit:
                Console.WriteLine("Hit and quit");
                break;
        }

    }
}
