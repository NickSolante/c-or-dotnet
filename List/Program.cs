using System;
using SplashKitSDK;

public class Program
{

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

    public static void Main()
    {
        double sum = 0;
        int numberOfValues = ReadInteger($"Give me the size of your array: ");
        Console.WriteLine(numberOfValues + " Just Checking here");


        double[] values = new double[numberOfValues];

        for (int i = 0; i < numberOfValues; i++)
        {
            values[i] = ReadDouble($"Enter the {i + 1}st value: ");

        }
        for (int i = 0; i < numberOfValues; i++)
        {
            Console.WriteLine(values[i]);

            sum += values[i];

        }
        Console.WriteLine("sum is equal to: " + sum);


    }
}
