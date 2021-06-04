using System;
using Domain.CentralCave;
using Domain.CentralCave.Enums;

namespace DAL.CentralCave.Contracts
{
    public interface IGetterConversion
    {
        Conversion GetLast(Currency origin, Currency destination);
    }
}
