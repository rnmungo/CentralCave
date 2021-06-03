namespace DAL.CentralCave.Contracts
{
    interface IEntityAdapter<T>
    {
        T Adapt(object[] values);
    }
}
