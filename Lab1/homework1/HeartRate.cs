using System;


namespace homework1
{
    class HeartRate: IoTDevices
    {
        public HeartRate(int bpm_)
        {
            this.bpm_ = bpm_;
        }
        public int bpm_{get;set;}
    
        public void ShowInfo(){
            System.Console.WriteLine("Heart rate is :"+bpm_);
        }
        
    }
}