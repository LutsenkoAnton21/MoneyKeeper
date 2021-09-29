using MoneyKeeper.Core.Entities;
using MoneyKeeper.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace MoneyKeeper.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext dbContext;
        public UserRepository(ApplicationContext databaseOptions)
        {
            dbContext = databaseOptions;
        }
        public void CreateUser(User user)
        { ///192.13.123.4 connection
            //INSERT INTO CLIENT VALUES .....
        }

        public User GetUserById(string userId)
        {
            ///192.13.123.4 connection
            /////SELECT * FROM CLIENT WHERE ClientId = @clientId
            return dbContext.Users.FirstOrDefault(x => x.Id == userId);
        }
    }
}
