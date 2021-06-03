using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Domain.CentralCave;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Tools;
using DAL.CentralCave.Repositories.SqlServer.Adapters;

namespace DAL.CentralCave.Repositories.SqlServer
{
    public class AccountRepository : IGetterRelationship<Account, Movement>
    {
        #region
        private string SelectOneByIDStatement
        {
            get => "SELECT Id, CreatedAt, CBU, CUIT, Currency, IdUser FROM [dbo].[Accounts] WHERE Id = @Id";
        }

        private string SelectOneByCBUStatement
        {
            get => "SELECT Id, CreatedAt, CBU, CUIT, Currency, IdUser FROM [dbo].[Accounts] WHERE CBU = @CBU";
        }

        private string SelectAllRelationsStatement
        {
            get => "SELECT Id, CreatedAt, Reason, IdAccount, Amount, IdTransaction FROM [dbo].[Movements] WHERE IdAccount = @IdAccount";
        }
        #endregion

        public Account GetOne(Guid id)
        {
            Account account = default;

            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneByIDStatement, System.Data.CommandType.Text, new SqlParameter("@Id", id)))
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
                // ExceptionManager.Current.Handle(this, ex);
            }

            return account;
        }

        public Account GetOne(long code)
        {
            Account account = default;

            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectOneByCBUStatement, System.Data.CommandType.Text, new SqlParameter("@CBU", code)))
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
                // ExceptionManager.Current.Handle(this, ex);
            }

            return account;
        }

        public List<Movement> GetRelated(Account entity)
        {
            List<Movement> movements = new List<Movement>();
            try
            {
                using (var dr = SqlHelper.ExecuteReader(SelectAllRelationsStatement, System.Data.CommandType.StoredProcedure, new SqlParameter("@IdAccount", entity.Id)))
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
                // ExceptionManager.Current.Handle(this, ex);
            }

            return movements;
        }
    }
}
