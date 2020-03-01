using Passenger.Core.Repositories;
using Passenger.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Infrastructure.Repositories
{
    class InMemoryDriverRepository : IDriverRepository
    {
        private static ISet<Driver> _drivers = new HashSet<Driver>();
       

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }

        public Driver Get(Guid userid)          
        {
            throw new Exception("error.");
        }

        public IEnumerable<Driver> GetAll()
            => _drivers;

        public void Update (Driver driver)
        {
            throw new NotImplementedException();
        }
    }
}
