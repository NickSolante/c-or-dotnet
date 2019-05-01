using SplashKitSDK;
using SplashKitSDK;

namespace CharacterDrawing1
{

    public class Program
    {
        public static void Main()
        {
            LightSimulator simulation = new LightSimulator();
            simulation.Run();
        }
    }

    public class LightSimulator
    {
        private Window _simWindow;
        private LightBulb _light;
        private LightSwitch _lightSwitch;

        public LightSimulator()
        {
            _light = new LightBulb(10, 10);

             _lightSwitch = new LightSwitch { ConnectedLight = _light, X = 215, Y = 400 };
        }

        public void Draw()
        {
            _simWindow.Clear(Color.White);
            _light.Draw();
            _lightSwitch.Draw();
            _simWindow.Refresh(60);
        }
        public void HandleInput()
        {
            SplashKit.ProcessEvents();
            if (_lightSwitch.IsUnderMouse && SplashKit.MouseClicked(MouseButton.LeftButton))
            {
                _lightSwitch.Switch();
            }
        }

        public void Run()
        {
            _simWindow = new Window("My Lightroom", 600, 600);
            LoadResources();

            while (!_simWindow.CloseRequested)
            {
                Draw();
                HandleInput();
            }

            _simWindow.Close();
        }

        private void LoadResources()
        {
            SplashKit.LoadBitmap("On", "medium-on-light.png");
            SplashKit.LoadBitmap("Off", "medium-off-light.png");
            SplashKit.LoadBitmap("OnSwitch", "switch-on.jpg");
            SplashKit.LoadBitmap("OffSwitch", "switch-off.jpg");
        }
    }

    public class LightBulb
    {
        private double _x, _y;
        private bool _power;

        public LightBulb(double x, double y)
        {
            _x = x;
            _y = y;
            _power = false;
        }

        public void TogglePower()
        {
            _power = !_power;
        }

        public Bitmap Image
        {
            get
            {
                if (_power)
                {
                    return SplashKit.BitmapNamed("On");
                }
                else
                {
                    return SplashKit.BitmapNamed("Off");
                }
                //  return SplashKit.BitmapNamed(_power ? "On" : "Off");
            }
        }

        public double X
        {
            set { _x = value; }
            get { return _x; }
        }

        public double Y
        {
            set { _y = value; }
            get { return _y; }
        }

        public void Draw()
        {
            Image.Draw(_x, _y);
        }
    }

    public class LightSwitch
    {
        private LightBulb _connectedLight;
        private double _x, _y;
        private bool _isOn;

        public LightSwitch()
        {
            _isOn = false;
        }

        public Bitmap Image
        {
            get
            {
                if (_isOn)
                {
                    return SplashKit.BitmapNamed("OnSwitch");
                }
                else
                {
                    return SplashKit.BitmapNamed("OffSwitch");
                }
            }
        }

        public double X
        {
            set { _x = value; }
            get { return _x; }
        }

        public double Y
        {
            set { _y = value; }
            get { return _y; }
        }

        public LightBulb ConnectedLight
        {
            set { _connectedLight = value; }
            get { return _connectedLight; }
        }

        public void Switch()
        {
           _connectedLight.TogglePower();
           _isOn = !_isOn;
        }

        public bool IsUnderMouse
        {
            get { return Image.PointCollision(_x, _y, SplashKit.MouseX(), SplashKit.MouseY()); }
        }

        public void Draw()
        {
            SplashKit.DrawBitmap(Image, _x, _y);
        }
    }
}
