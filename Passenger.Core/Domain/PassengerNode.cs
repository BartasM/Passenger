using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    // punkt zabrania pasazera - DailyRoute bedzie miał ich liste

         // powiązanie Node - czyli w jakim miejscu zabrac pasazera i jakiego pasażera
    class PassengerNode
    {
   
        public Node Node { get; protected set; }
        public Passenger Passenger { get; protected set; }
    }
}
