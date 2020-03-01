using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{

    // Agregate root - korzeń które posiada wartościowe zachowania. Pojazd jest integralną częścią kierowcy
    public class Driver 
    {
      
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public IEnumerable<Route> Routes { get; protected set; } 
    

        protected Driver()
        {

        }
        public Driver(Guid userid)
        {           
            UserId = userid;
        }



    }
}
