using System;
using Domain.CentralCave;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Tools;
using System.Data.SqlClient;

namespace DAL.CentralCave.Repositories.SqlServer
{
    internal class MovementRepository : IInserter<Movement>
    {
        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Movements] (Reason, IdAccount, Amount, IdTransaction) VALUES (@Reason, @IdAccount, @Amount, @IdTransaction)";
        }
        #endregion

        public void Insert(Movement entity)
        {
            try
            {
                entity.Id = (Guid)SqlHelper.ExecuteScalar(
                    InsertStatement,
                    System.Data.CommandType.Text,
                    new SqlParameter("@Reason", entity.Reason),
                    new SqlParameter("@IdAccount", entity.IdAccount),
                    new SqlParameter("@Amount", entity.Amount),
                    new SqlParameter("@IdTransaction", entity.IdTransaction));
            }
            catch (Exception ex)
            {
                // SL.Services.ExceptionManager.Current.Handle(this, ex);
            }
        }
    }
}
