using System;

namespace DAL.CentralCave.Contracts
{
    public interface IAccountRelationship<T, U> : IRelationship<T, U>
    {
        T GetWallet(Guid idUser);
        T GetSavingAccount(Guid idUser);
    }
}
