﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    // punkt zabrania pasazera
    class PassengerNode
    {
   
        public Node Node { get; protected set; }
        public Passenger Passenger { get; protected set; }
    }
}