using System;
using DAL.CentralCave.Contracts;
using Domain.CentralCave;

namespace DAL.CentralCave.Repositories.SqlServer
{
    internal class UserRepository : IUserRepository
    {
        public User Login(string name, string password)
        {
            throw new NotImplementedException();
        }
    }
}
