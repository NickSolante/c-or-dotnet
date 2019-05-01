using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window w = new Window("Balloon pop!", 800, 900);
        Balloon smallBalloon;
        smallBalloon = new Balloon();


        while (! w.CloseRequested )
        {

            if(KeyCode.SpaceKey()){
                
            }
            SplashKit.ProcessEvents();
            
            w.Clear(Color.White);
            smallBalloon.Draw();
            w.Refresh(60);


        }
        SplashKit.Delay(1000);



    }
}
