using System;

namespace decorator
{
	class SnowDecorator: Decorator
    {
        public SnowDecorator(IWeatherAlert weather): base(weather){}
        public override void Alert(){
            base.Alert();
            System.Console.WriteLine("and snow");
        }

    }
}