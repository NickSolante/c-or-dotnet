using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window helloWindow;
        Window yetAnotherWindow;
        
        helloWindow = new Window ("hello World", 800 , 600);

        yetAnotherWindow = helloWindow;

        helloWindow.MoveTo(0,0);
        helloWindow.Clear(Color.Blue);
        helloWindow.Refresh(60);

        yetAnotherWindow.Clear(Color.Green);
        yetAnotherWindow.Refresh(60);

        SplashKit.Delay(50000);

    }
}
