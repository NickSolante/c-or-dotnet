using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window shapesWindow = new Window("House Drawing", 1000, 1000);
        Bitmap scene1 = new Bitmap("Beach", "domo3.png");
        Bitmap scene2 = new Bitmap("vader", "darth_vader.jpg");
        SoundEffect vaderz = new SoundEffect("march", "darth_vader.mp3");
        SoundEffect domo = new SoundEffect("domosound", "kun_faya_kun_atif.wav");

        shapesWindow.Clear(Color.White);
        shapesWindow.DrawBitmap(scene1, 0, 0);
        vaderz.Play();


        shapesWindow.DrawBitmap(scene2, 0, 0);
        domo.Play();

        shapesWindow.Refresh(60);

        SplashKit.Delay(10000);

    }
}
