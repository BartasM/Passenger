using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    class Driver // Agregate root - pojazd musi być integralną częścią kierowcy, pojazd nie ma sensu isntnieć sam
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Vehicle Vehicle { get; protected set; }

        public IEnumerable<Route> Routes { get; protected set; }
        public IEnumerable<DailyRoute> DailtRoutes { get; protected set; }
    }
}
