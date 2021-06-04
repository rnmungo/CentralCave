using System;
using Domain.CentralCave;
using DAL.CentralCave.Contracts;

namespace DAL.CentralCave.Repositories.SqlServer.Adapters
{
    public sealed class UserAdapter : IEntityAdapter<User>
    {
        #region Singleton
        private readonly static UserAdapter _instance = new UserAdapter();

        public static UserAdapter Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        public User Adapt(object[] values)
        {
            return new User()
            {
                Id = Guid.Parse(values[(int)Columns.ID].ToString()),
                Name = values[(int)Columns.NAME].ToString(),
                IdWallet = Guid.Parse(values[(int)Columns.ID_WALLET].ToString()),
                IdSavingAccount = Guid.Parse(values[(int)Columns.ID_SAVING_ACCOUNT].ToString())
            };
        }

        private enum Columns
        {
            ID,
            NAME,
            ID_WALLET,
            ID_SAVING_ACCOUNT
        }
    }
}
