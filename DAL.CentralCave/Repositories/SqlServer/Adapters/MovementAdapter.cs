using System;
using DAL.CentralCave.Contracts;
using Domain.CentralCave;
using Domain.CentralCave.Enums;

namespace DAL.CentralCave.Repositories.SqlServer.Adapters
{
    public sealed class MovementAdapter : IEntityAdapter<Movement>
    {
        private readonly static MovementAdapter _instance = new MovementAdapter();

        public static MovementAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        public Movement Adapt(object[] values)
        {
            return new Movement()
            {
                Id = Guid.Parse(values[(int)Columns.ID].ToString()),
                CreatedAt = DateTime.Parse(values[(int)Columns.CREATED_AT].ToString()),
                Reason = (Reason)int.Parse(values[(int)Columns.REASON].ToString()),
                IdAccount = Guid.Parse(values[(int)Columns.ACCOUNT].ToString()),
                Amount = decimal.Parse(values[(int)Columns.AMOUNT].ToString()),
            };
        }

        private enum Columns
        {
            ID,
            CREATED_AT,
            REASON,
            ACCOUNT,
            AMOUNT
        }
    }
}
