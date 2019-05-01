using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window shapesWindow;
        shapesWindow = new Window("House Drawing", 800, 600);

        shapesWindow.Clear(Color.White);
        // shapesWindow.FillEllipse(Color.BrightGreen, 0, 400, 800, 400);
        shapesWindow.FillRectangle(Color.Gray, 300, 300, 200, 200);
        // shapesWindow.FillTriangle(Color.Pink, 350, 400, 400, 150, 550, 300);
        shapesWindow.Refresh();

        SplashKit.Delay(10000);


    }
}
