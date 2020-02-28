using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class DailyRoute
    {
        public Guid Id { get; protected set; }
        public Route Route { get; protected set; } // gdzie sie trasa konczy gdzie zaczyna
        public IEnumerable<PassengerNode> PassengerNodes { get; protected set; } // 
    }
}
