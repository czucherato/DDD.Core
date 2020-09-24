using System.Threading.Tasks;

namespace DDD.Core.Common.Data
{
    /// <summary>
    /// Interface for Unit of Work
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Starts a transaction state
        /// </summary>
        /// <returns>Task for async flow</returns>
        Task BeginTransaction();

        /// <summary>
        /// Successful completion of a transaction
        /// </summary>
        /// <returns>Task for async flow</returns>
        Task Commit();

        /// <summary>
        /// Unsuccessful completion of a transaction
        /// </summary>
        /// <returns>Task for async flow</returns>
        Task Rollback();
    }
}