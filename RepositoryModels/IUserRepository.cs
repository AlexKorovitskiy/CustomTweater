using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryModels
{
    public interface IUserRepository: IEntityRepository<User>
    {
        User GetUser(string Login, string password);
    }
}
