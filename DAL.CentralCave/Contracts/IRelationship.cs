using System.Collections.Generic;

namespace DAL.CentralCave.Contracts
{
    public interface IRelationship<T, U>
    {
        /// <summary>
        /// Get items related to a source entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>List of related items</returns>
        List<U> GetRelated(T entity);
    }
}
