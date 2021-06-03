using Domain.CentralCave;

namespace DAL.CentralCave.Contracts
{
    public interface IUserRepository
    {
        User Login(string name, string password);
    }
}
