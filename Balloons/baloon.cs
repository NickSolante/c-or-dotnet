using System;
using SplashKitSDK;

public class Balloon
{
    private double _x;
    private double _y;

    public Balloon () 
    {
        _x = SplashKit.Rnd(SplashKit.ScreenWidth());
        _y = SplashKit.Rnd(SplashKit.ScreenHeight());
    
    }
    public void Draw() {
        SplashKit.FillCircle(Color.Green, _x,_y, 50);
    }

}
