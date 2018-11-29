using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public interface IUserService : IInfoModelService<UserInfo>
    {
        UserInfo GetUser(string login, string password);
        void RgisterNewUser(UserInfo user);
    }
}
