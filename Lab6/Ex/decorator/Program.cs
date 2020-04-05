using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeatherAlert monday =new RainAlert();
            monday = new WindDecorator(monday);
            IWeatherAlert tuesday = new NoAlert();
            tuesday = new FogDecorator(tuesday);
            IWeatherAlert wedensday = new RainAlert();
            wedensday = new WindDecorator(wedensday);
            wedensday = new SnowDecorator(wedensday);
            monday.Alert();
            tuesday.Alert();
            wedensday.Alert();
        }
    }
}
