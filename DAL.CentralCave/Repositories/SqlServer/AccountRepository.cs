using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Domain.CentralCave;
using Domain.CentralCave.Enums;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Tools;
using DAL.CentralCave.Repositories.SqlServer.Adapters;

namespace DAL.CentralCave.Repositories.SqlServer
{
    public class AccountRepository : IAccountRelationship<Account, Movement>
    {
        #region Statements
        private string SelectOneStatement
        {
            get => "SELECT Id, CreatedAt, CBU, Currency, IdUser FROM [dbo].[Accounts] WHERE IdUser = @IdUser AND Currency = @Currency";
        }

        private string SelectAllRelationsStatement
        {
            get => "SELECT Id, CreatedAt, Reason, IdAccount, Amount, IdTransaction FROM [dbo].[Movements] WHERE IdAccount = @IdAccount";
        }
        #endregion

        public Account GetOne(Guid idUser, Currency currency)
        {
            Account account = default;

            try
            {
                using (var dr = SqlHelper.ExecuteReader(
                    SelectOneStatement,
                    System.Data.CommandType.Text,
                    new SqlParameter("@IdUser", idUser),
                    new SqlParameter("@Currency", currency)))
                {
                    if (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        account = AccountAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return account;
        }

        public List<Movement> GetRelated(Account entity)
        {
            List<Movement> movements = new List<Movement>();
            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectAllRelationsStatement, System.Data.CommandType.Text, new SqlParameter("@IdAccount", entity.Id)))
                {
                    while (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        Movement movement = MovementAdapter.Current.Adapt(values);
                        movements.Add(movement);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return movements;
        }
    }
}
