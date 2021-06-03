using System;
using System.Data.SqlClient;
using Domain.CentralCave;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Tools;

namespace DAL.CentralCave.Repositories.SqlServer
{
    internal class TransactionRepository : IInserter<Transaction>
    {
        #region
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Transactions] (IdUser) VALUES (@IdUser)";
        }
        #endregion

        public void Insert(Transaction entity)
        {
            try
            {
                entity.Id = (Guid)SqlHelper.ExecuteScalar(
                    InsertStatement,
                    System.Data.CommandType.Text,
                    new SqlParameter("@IdUser", entity.IdUser));
            }
            catch (Exception ex)
            {
                // SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
