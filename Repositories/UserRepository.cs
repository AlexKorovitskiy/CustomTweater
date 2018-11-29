using RepositoryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class UserRepository : AbstractRepository<User>, IUserRepository
    {
        public User GetUser(string login, string password)
        {
            return ApplicationContext.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
        }
    }
}
