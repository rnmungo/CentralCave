using System;
using System.Data.SqlClient;
using Domain.CentralCave;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Tools;

namespace DAL.CentralCave.Repositories.SqlServer
{
    internal class TransactionRepository : IInserter<Transaction>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Transactions] (IdUser) OUTPUT Inserted.Id VALUES (@IdUser)";
        }
        #endregion

        public void Insert(Transaction entity)
        {
            try
            {
                entity.Id = (long)SqlHelper.ExecuteScalar(
                    InsertStatement,
                    System.Data.CommandType.Text,
                    new SqlParameter("@IdUser", entity.IdUser));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
