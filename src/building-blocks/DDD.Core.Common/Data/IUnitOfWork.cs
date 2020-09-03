using System.Threading.Tasks;

namespace DDD.Core.Common.Data
{
    public interface IUnitOfWork
    {
        Task BeginTransaction();

        Task Commit();

        Task Rollback();
    }
}