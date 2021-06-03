using Domain.CentralCave;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Repositories.SqlServer;

namespace DAL.CentralCave.Factories
{
    public sealed class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new Factory();

        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }

        private Factory() { }
        #endregion

        /// <summary>
        /// Make a Movements Repository
        /// </summary>
        /// <returns>Movements Repository</returns>
        public IInserter<Movement> GetMovementRepository()
        {
            return new MovementRepository();
        }

        /// <summary>
        /// Make a Transactions Repository
        /// </summary>
        /// <returns>Transactions Repository</returns>
        public IInserter<Transaction> GetTransactionRepository()
        {
            return new TransactionRepository();
        }

        /// <summary>
        /// Make an Users Repository
        /// </summary>
        /// <returns>Users Repository</returns>
        public IUserRepository GetUserRepository()
        {
            return new UserRepository();
        }

        /// <summary>
        /// Make an Accounts Repository
        /// </summary>
        /// <returns>Accounts Repository</returns>
        public IGetterRelationship<Account, Movement> GetAccountRepository()
        {
            return new AccountRepository();
        }
    }
}
