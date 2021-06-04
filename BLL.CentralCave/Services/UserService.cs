using DAL.CentralCave.Contracts;
using DAL.CentralCave.Factories;
using Domain.CentralCave;
using Domain.CentralCave.Enums;
using SL.CentralCave.Services;
using BLL.CentralCave.BusinessExceptions;
using BLL.CentralCave.Contracts;

namespace BLL.CentralCave.Services
{
    public sealed class UserService : BaseService, IUserService
    {
        IAccountRelationship<Account, Movement> accountRepository = Factory.Current.GetAccountRepository();
        IUserRepository userRepository = Factory.Current.GetUserRepository();

        #region Singleton
        private readonly static UserService _instance = new UserService();

        public static UserService Current
        {
            get
            {
                return _instance;
            }
        }

        private UserService() { }
        #endregion

        public User Login(string name, string password)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new InvalidCredentialsException("the name is required");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new InvalidCredentialsException("the password is required");
            }

            return SurroundTransaction(() =>
            {
                string hashedPassword = Encryptor.Current.Compute(password);
                User user = userRepository.Login(name, hashedPassword);
                if (user is null)
                {
                    throw new InvalidCredentialsException("the name or password does not match");
                }

                user.SavingAccount = accountRepository.GetOne(user.Id, Currency.ARS);
                user.Wallet = accountRepository.GetOne(user.Id, Currency.BTC);
                return user;
            });
        }
    }
}
