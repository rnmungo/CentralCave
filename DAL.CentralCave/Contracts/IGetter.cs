using System;
using System.Collections.Generic;

namespace DAL.CentralCave.Contracts
{
    public interface IGetter<T>
    {
        T GetOne(Guid id);
        T GetOne(long code);
    }
}
