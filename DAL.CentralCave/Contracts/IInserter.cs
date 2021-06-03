namespace DAL.CentralCave.Contracts
{
    public interface IInserter<T>
    {
        void Insert(T entity);
    }
}
