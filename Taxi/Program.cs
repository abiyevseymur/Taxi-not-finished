using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Seymur Abiyev",50,40,150,140);
            Taxi taxi2 = new Taxi(366, 37, 44);
            Taxi taxi1 = new Taxi(365, 87, 94);
        }
    }
}
