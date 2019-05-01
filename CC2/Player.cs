using System;
using SplashKitSDK;

public class Player
{
    private Bitmap _PlayerBitmap;
    public double X { get; private set; }
    public double Y { get; private set; }
    public int Width
    {
        get
        {
            return _PlayerBitmap.Width;
        }
    }

    public Player(Window gameWindow, double PlayerX, double PlayerY)
    {
        _PlayerBitmap = new Bitmap("user", "Player.png");
        X = (gameWindow.Width - Width) / 2;
        Y = (gameWindow.Height) / 2;
    }

    public void Draw(Window gameWindow)
    {
        gameWindow.DrawBitmap(_PlayerBitmap, X, Y);
    }

}
