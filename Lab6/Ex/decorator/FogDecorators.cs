using System;

namespace decorator
{
	class FogDecorator: Decorator
    {
        public FogDecorator(IWeatherAlert weather): base(weather){}
        public override void Alert(){
            base.Alert();
            System.Console.WriteLine("and fog");
        }

    }
}