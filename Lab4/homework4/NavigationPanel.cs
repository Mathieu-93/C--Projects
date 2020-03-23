using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class NavigationPanel:ITool
    {
        private int currentNumber=0;
        private List<Destination> ports = new List<Destination>();
        private List<int> travelDays = new List<int>();
        public int TotalNumber{
                get{
                    int tDays=0; 
                    foreach(int elem in travelDays){
                        tDays+=elem;
                    }
                return tDays;
                }
            }
        public void AddPort(string name, int days){
            travelDays.Add(days);
            ports.Add(new Destination(name));
        }
        public void Arrived(){}
        public void Conserve(){}
        public int DaysToNextDestination(){
            return travelDays[currentNumber];
        }
        public NavigationPanel(){}
        public string NextDestination(){
            Destination actualPort = ports[currentNumber];
            currentNumber++;
            return actualPort.Name;
        }


    }
}