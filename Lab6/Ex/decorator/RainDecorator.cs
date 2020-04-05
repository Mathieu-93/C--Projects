using System;

namespace decorator
{
	class RainDecorator: Decorator
    {
        public RainDecorator(IWeatherAlert weather): base(weather){}
        public override void Alert(){
            base.Alert();
            System.Console.WriteLine("and  rain");
        }

    }
}