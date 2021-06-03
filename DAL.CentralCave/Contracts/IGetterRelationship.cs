namespace DAL.CentralCave.Contracts
{
    public interface IGetterRelationship<T, U> : IRelationship<T, U>, IGetter<T> { }
}
