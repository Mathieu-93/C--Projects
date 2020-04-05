using System;

namespace decorator
{
	class WindDecorator: Decorator
    {
        public WindDecorator(IWeatherAlert weather): base(weather){}
        public override void Alert(){
            base.Alert();
            System.Console.WriteLine("and wind");
        }

    }
}