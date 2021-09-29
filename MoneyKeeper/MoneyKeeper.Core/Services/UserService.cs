using MoneyKeeper.Core.Entities;
using MoneyKeeper.Core.Interfaces;
using MoneyKeeper.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKeeper.Core.Services
{
    public class UserService 
    {
        private readonly IUserRepository _usersRepository;
        public UserService(IUserRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public void CreateUser(User user)
        {
            _usersRepository.CreateUser(user);
        }

        public User GetUserById(string userId)
        {
            return _usersRepository.GetUserById(userId);
        }
    }
}
