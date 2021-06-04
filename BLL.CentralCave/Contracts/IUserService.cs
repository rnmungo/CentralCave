using Domain.CentralCave;

namespace BLL.CentralCave.Contracts
{
    public interface IUserService
    {
        User Login(string name, string password);
    }
}
