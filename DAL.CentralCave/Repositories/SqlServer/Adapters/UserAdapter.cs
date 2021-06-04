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
            };
        }

        private enum Columns
        {
            ID,
            NAME,
        }
    }
}
