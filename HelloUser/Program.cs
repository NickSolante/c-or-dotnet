using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        String name = "john";
        String inputText;
        int heightInCM;
        double weightInKG;
        double heightInMeters;
        double bmi;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello " + name);
        Console.Write("Height in centimeters: ");

        inputText = Console.ReadLine();
        heightInCM = Convert.ToInt32(inputText);
        Console.WriteLine("Height in CMeters " + heightInCM);
        heightInMeters = heightInCM / 100.0;
        Console.Write("Enter your weight in Kilograms: ");
        weightInKG = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Height in Meters " + heightInMeters);
        Console.WriteLine("Weight is " + weightInKG);

        bmi = heightInMeters * heightInMeters;
        bmi = weightInKG / bmi;

        Console.WriteLine("your bmi is " + bmi);



        SplashKit.Delay(1000);

    }
}
