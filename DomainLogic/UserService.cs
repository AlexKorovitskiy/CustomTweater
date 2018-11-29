using DomainModels;
using RepositoryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLogic
{
    public class UserService : AbstractService<UserInfo, User>, IUserService
    {
        protected IUserRepository userRepository;
        protected IEmailService emailService;

        public UserService(IEntityRepository<User> userRepository, IEmailService emailService)
            : base(userRepository)
        {
            this.userRepository = (IUserRepository)userRepository;
            this.emailService = emailService;
        }

        public UserInfo GetUser(string login, string password)
        {
            var user = userRepository.GetUser(login, password);
            return AutoMapper.Mapper.Map<User, UserInfo>(user);
        }

        public void RgisterNewUser(UserInfo user)
        {
            this.Create(user);
            this.emailService.SendEmailAsync("alex.korovitskiy@gmail.com","Confirm","Hi");
        }
    }
}
