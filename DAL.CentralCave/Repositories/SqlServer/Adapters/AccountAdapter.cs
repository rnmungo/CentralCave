using System;
using Domain.CentralCave;
using Domain.CentralCave.Enums;
using DAL.CentralCave.Contracts;

namespace DAL.CentralCave.Repositories.SqlServer.Adapters
{
    public sealed class AccountAdapter : IEntityAdapter<Account>
    {
        private readonly static AccountAdapter _instance = new AccountAdapter();

        public static AccountAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        public Account Adapt(object[] values)
        {
            return new Account()
            {
                Id = Guid.Parse(values[(int)Columns.ID].ToString()),
                CreatedAt = DateTime.Parse(values[(int)Columns.CREATED_AT].ToString()),
                CBU = long.Parse(values[(int)Columns.CBU].ToString()),
                CUIT = long.Parse(values[(int)Columns.CUIT].ToString()),
                Currency = (Currency)int.Parse(values[(int)Columns.CURRENCY].ToString()),
                IdUser = Guid.Parse(values[(int)Columns.ID_USER].ToString())
            };
        }

        private enum Columns
        {
            ID,
            CREATED_AT,
            CBU,
            CUIT,
            CURRENCY,
            ID_USER
        }
    }
}
