using System;
using System.Data.SqlClient;
using DAL.CentralCave.Contracts;
using DAL.CentralCave.Repositories.SqlServer.Adapters;
using DAL.CentralCave.Tools;
using Domain.CentralCave;

namespace DAL.CentralCave.Repositories.SqlServer
{
    internal class UserRepository : IUserRepository
    {
        #region Statements
        private string SelectStatement
        {
            get => "SELECT Id, Name, IdWallet, IdSavingAccount FROM [dbo].[Users] WHERE Name = @Name AND Password = @Password";
        }
        #endregion

        public User Login(string name, string password)
        {
            User user = default;

            try
            {
                using (var dr = SqlHelper.ExecuteReader(
                    SelectStatement,
                    System.Data.CommandType.Text,
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Password", password)))
                {
                    if (dr.Read())
                    {
                        object[] values = new object[dr.FieldCount];
                        dr.GetValues(values);
                        user = UserAdapter.Current.Adapt(values);
                    }
                }
            }
            catch (Exception ex)
            {
                // ExceptionManager.Current.Handle(this, ex);
            }

            return user;
        }
    }
}
