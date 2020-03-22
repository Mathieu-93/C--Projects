using System;
using System.Collections.Generic;
using System.Text;

namespace C4
{
    class NavigationPanel:ITool
    {
        private int currentNumber;
        private List<Destination> ports = new List<Destination>();
        private List<int> travelDays = new List<int>();
        public int ToolNumber{get;set;}
        public void AddPort(string name, int days){}
        public void Arrived(){}
        public void Conserve(){}
        public int DaysToNextDestination(){}
        public NavigationPanel(){}
        public string DaysToNextDestination(){}


    }
}