using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window gamingWindow = new Window("Hello", 800, 800);

        gamingWindow.Clear(Color.White);


        Player Nero = new Player(gamingWindow, 800, 800);

        Nero.Draw(gamingWindow);

        gamingWindow.Refresh(60);

        SplashKit.Delay(200000);


    }
}
