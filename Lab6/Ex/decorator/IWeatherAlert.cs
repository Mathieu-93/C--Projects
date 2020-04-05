using System;

namespace decorator
{
	interface IWeatherAlert
    {
        string CurrentDate { get; set; }
        void Alert();
    }

    class NoAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert() { }
    }
    class RainAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: rain");
        }
    }

    class SnowAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: snow");
        }
    }

    class FogAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: fog");
        }
    }


    class WindAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: wind");
        }
    }

}