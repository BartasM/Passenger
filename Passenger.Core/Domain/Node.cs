using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class Node
    {
        public string Adress { get; protected set; }
        public double Longitude { get; protected set; }
        public double Latitude { get; protected set; }
    }
}
