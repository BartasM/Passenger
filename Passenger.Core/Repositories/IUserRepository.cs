using Passenger.Core.Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid id);
        User Get(string email);
        void Add(User user); //zapisze uzytkownika do bazy
        void Update(Guid id);
        void Remove(Guid id);
        IEnumerable<User> GetAll(); // pozniej może dodać jakąś paginacje do wszystkich użytkowników

        //Pomyśleć co ma sens żeby zostało zwrócone, node nie ma sensu całkowicie więc chyba trzeba będzie to opakować
        
    }
}
