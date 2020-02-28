using System;
using System.Collections.Generic;
using System.Linq;
using Passenger.Core.Domain;
using Passenger.Core.Repositories;

namespace Passenger.Infrastructure
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>
        {
            new User("user1@gmail.com", "user1", "secret", "salt"),
            new User("user2@gmail.com", "user2", "secret2", "salt2"),
            new User("user3@gmail.com", "user3", "secret3", "salt3")
        };

        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(Guid id)
           => _users.Single(x => x.Id == id);


        public User Get(string email)
            => _users.Single(x => x.Email == email.ToLowerInvariant());

        public IEnumerable<User> GetAll()
            => _users;

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }


        public void Update(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
