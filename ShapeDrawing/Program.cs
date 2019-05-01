using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window shapesWindow;
        shapesWindow = new Window("House Drawing", 1000, 800);

        shapesWindow.Clear(Color.Green);
        // shapesWindow.FillEllipse(Color.BrightGreen, 0, 400, 800, 400);
        //body                           horizontal,vertical,width,height
        shapesWindow.FillRectangle(Color.Blue, 250, 300, 500, 200);
        //top
        shapesWindow.FillRectangle(Color.Blue, 350, 200, 300, 100);
        //windows
        shapesWindow.FillRectangle(Color.Black, 380, 225, 85, 50);
        shapesWindow.FillRectangle(Color.Black, 540, 225, 85, 50);
        
        //wheels
        shapesWindow.FillCircle(Color.Black, 650, 500, 75);
        shapesWindow.FillCircle(Color.Black, 355, 500, 75);

        //wheel caps
        shapesWindow.FillCircle(Color.Gray, 650, 500, 50);
        shapesWindow.FillCircle(Color.Gray, 355, 500, 50);

        //light
        shapesWindow.FillCircle(Color.White, 275, 400, 40);
        //rear light
        shapesWindow.FillRectangle(Color.Red, 700, 400, 60, 30);


        shapesWindow.Refresh();

        SplashKit.Delay(50000);


    }
}
