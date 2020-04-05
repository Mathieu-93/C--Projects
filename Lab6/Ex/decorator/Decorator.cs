using System;

namespace decorator
{
	abstract class Decorator: IWeatherAlert
    {
        protected IWeatherAlert weather ;
        public Decorator(IWeatherAlert weather){
            this.weather = weather;
        }
        public virtual string CurrentDate{
            get{return weather.CurrentDate;}
            set{weather.CurrentDate=value;}
        }
        public virtual void Alert(){
            weather.Alert();
        }
    }
}
