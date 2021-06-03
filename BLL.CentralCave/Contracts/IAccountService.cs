using Domain.CentralCave;

namespace BLL.CentralCave.Contracts
{
    public interface IAccountService
    {
        void Deposit(Account account, decimal amount);
        void ConvertTo(Account origin, Account destination, decimal amount);
        void Transfer(Account origin, Account destination, decimal amount);
        Account GetOne(long cbu);
    }
}
