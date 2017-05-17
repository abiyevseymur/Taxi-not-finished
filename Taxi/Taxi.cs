using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        private int number;
        private int coordX;
        private int coordY;

        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        public int CoordX
        {
            get
            {
                return this.coordX;
            }
            set
            {
                this.coordX = value;
            }
        }
        public int CoordY
        {
            get
            {
                return this.coordY;
            }
            set
            {
                this.coordY = value;
            }
        }
        public Taxi(int numb,int coordX,int coordY)
        {
            this.number = numb;
            this.coordX = coordX;
            this.coordY = coordY;
        }
    }
}
