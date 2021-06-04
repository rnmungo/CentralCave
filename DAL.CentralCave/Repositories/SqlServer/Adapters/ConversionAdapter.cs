using System;
using Domain.CentralCave;
using Domain.CentralCave.Enums;
using DAL.CentralCave.Contracts;

namespace DAL.CentralCave.Repositories.SqlServer.Adapters
{
    public sealed class ConversionAdapter : IEntityAdapter<Conversion>
    {
        #region Singleton
        private readonly static ConversionAdapter _instance = new ConversionAdapter();

        public static ConversionAdapter Current
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        public Conversion Adapt(object[] values)
        {
            return new Conversion()
            {
                Id = Guid.Parse(values[(int)Columns.ID].ToString()),
                CreatedAt = DateTime.Parse(values[(int)Columns.CREATED_AT].ToString()),
                Rate = decimal.Parse(values[(int)Columns.RATE].ToString()),
                Origin = (Currency)int.Parse(values[(int)Columns.ORIGIN].ToString()),
                Destination = (Currency)int.Parse(values[(int)Columns.DESTINATION].ToString()),
            };
        }

        private enum Columns
        {
            ID,
            CREATED_AT,
            RATE,
            ORIGIN,
            DESTINATION
        }
    }
}
