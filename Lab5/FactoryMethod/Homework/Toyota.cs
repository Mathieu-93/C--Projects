using System;

namespace Homework
{
    class Toyota: Car
    {
        public Toyota(string engine_,string body_, string tyre_)
        {
            this.body =body_;
            this.tyre =tyre_;
            this.engine = engine_;
        }

        public override string ShowParameters(){
            return "This model works with "+engine +" engine\nBody: "+body+" and "+tyre+" tyre.";
        }
        
    }
}