using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Client
    {
        private string fullName;
        private int starCoordX;
        private int starCoordY;
        private int endCoordX;
        private int endCoordY;
        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                this.fullName = value;
            }
        }
        public int StartCoordX
        {
            get
            {
                return this.starCoordX;
            }
            set
            {
                this.starCoordX = value;
            }
        }
        public int StartCoordY
        {
            get
            {
                return this.starCoordY;
            }
            set
            {
                this.starCoordY = value;
            }
        }
        public int EndCoordX
        {
            get
            {
                return this.endCoordX;
            }
            set
            {
                this.endCoordX = value;
            }
        }
        public int EndCoordY
        {
            get
            {
                return this.endCoordY;
            }
            set
            {
                this.endCoordY = value;
            }
        }
        public Client(string name, int startX,int startY,int endX,int endY)
        {
            this.fullName = name;
            this.starCoordX = startX;
            this.StartCoordY = startY;
            this.endCoordX = endX;
            this.endCoordY = endY;
        }
        public double CheckDistance()
        {
            int distance;
            distance = (EndCoordX - StartCoordX) * (EndCoordX - StartCoordX) + (EndCoordY - StartCoordY) * (EndCoordY - StartCoordY);
            double realDistance = Math.Sqrt(distance);
            return realDistance;
            Console.WriteLine(realDistance);
        }
    }
}
