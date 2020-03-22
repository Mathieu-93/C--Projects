using System;
using System.Collections.Generic;


namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            IoTDevices myDevice1 = new IoTDevices();
            HeartRate HR = new HeartRate(200);
            myDevice1.ID = "tak124";
            myDevice1.NameDevice= "Temperature sensor";
            myDevice1.BateryLevel=5;

            myDevice1.PrintAll();
            myDevice1.PrintStatus();
            myDevice1.HowManyDevices();
            


            HR.bpm_ = 130;
            HR.NameDevice="HeartRate";
            HR.PrintAll();
            HR.ShowInfo();

            List<IoTDevices> myRoom = new List<IoTDevices>();
            myRoom.Add(new IoTDevices(){NameDevice= "Temperature"});
            myRoom.Add(new IoTDevices(){NameDevice= "Humidity"});
            myRoom.Add(new IoTDevices(){NameDevice= "HeartRate"});
            myRoom.Add(new IoTDevices(){NameDevice= "Pressure"});

            foreach(IoTDevices dev in myRoom){
                dev.PrintAll();
            
            }
            Vector2D myVec = new Vector2D(5,1);
            Vector2D myVec1 = new  Vector2D(1,5);
            Console.WriteLine(myVec+myVec1);
            Console.WriteLine(myVec.Length);
        
        }   
    }
}