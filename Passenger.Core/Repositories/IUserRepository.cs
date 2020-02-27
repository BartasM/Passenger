using Passenger.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Repositories
{
    interface IUserRepository
    {
        User Get(Guid id);
        User Get(string email);
        void Add(User user);
        void Update(Guid id);
        void Remove(Guid id);
        IEnumerable<User> GetAll();
        
    }
}
