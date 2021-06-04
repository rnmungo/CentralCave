using System;
using Domain.CentralCave.Enums;

namespace DAL.CentralCave.Contracts
{
    public interface IAccountRelationship<T, U> : IRelationship<T, U>
    {
        T GetOne(Guid idUser, Currency currency);
    }
}
