using System;

namespace homework1
{
    class IoTDevices{
        public IoTDevices()
        {   
            nameDevice = "Unknown";
            iD = "######";
            bateryLevel = 100;

            counter++;
        }
        private int bateryLevel;
        static private int counter;
        
        public int BateryLevel{
            get {return bateryLevel;}
            set {
                if((value>0) && (value<=100)){bateryLevel = value;}
                else{Console.WriteLine("Batery level is out of range");}
                }
        } 

        private string nameDevice,iD; 

        public string ID{
            get {return iD;}
            
             set {if (value.Length == 6){iD = value;}
                 else{Console.WriteLine("ID must contain 6 charaters");}
                 }
             }
        
        public string NameDevice{
            get{ return nameDevice;}
            set{ nameDevice= value;}
            }

        private bool EnergySaving(){
            if (bateryLevel<20){return true ;}
            else{return false;}
        }

        public void PrintStatus(){
            if(EnergySaving() == true)
                Console.WriteLine("Low  batery status...");
            else{
                Console.WriteLine("Batery status is high enough.");
            }
        }
        public void PrintAll(){
            Console.WriteLine("Name of device "+NameDevice+" with ID:"+ID+"\nBatery Level: "+BateryLevel+"%\n");
        }
        
        public void HowManyDevices(){
            System.Console.WriteLine("Currently is available :"+ counter+" devices");
        }
    }
        
}
