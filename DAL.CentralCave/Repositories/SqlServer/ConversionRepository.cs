using System;
using System.Data.SqlClient;
using Domain.CentralCave;
using Domain.CentralCave.Enums;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Repositories.SqlServer.Adapters;
using DAL.CentralCave.Tools;

namespace DAL.CentralCave.Repositories.SqlServer
{
    public class ConversionRepository : IGetterConversion
    {
        #region Statements
        private string SelectOneStatement
        {
            get => "SELECT TOP 1 Id, CreatedAt, Rate, Origin, Destination FROM [dbo].[Conversions] WHERE Origin = @Origin AND Destination = @Destination AND CreatedAt <= @CreatedAt ORDER BY CreatedAt DESC";
        }
        #endregion

        public Conversion GetLast(Currency origin, Currency destination)
        {
            Conversion conversion = default;

            try
            {
                using (var dr = SqlHelper.ExecuteReader(
                    SelectOneStatement,
                    System.Data.CommandType.Text,
                    new SqlParameter("@Origin", origin),
                    new SqlParameter("@Destination", destination),
                    new SqlParameter("@CreatedAt", DateTime.Now)))
                {
                    if (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        conversion = ConversionAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                // ExceptionManager.Current.Handle(this, ex);
            }

            return conversion;
        }
    }
}
