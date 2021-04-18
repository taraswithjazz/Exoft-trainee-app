using System;
using System.Threading;
using System.Threading.Tasks;

namespace Trainee_app_backend.Data.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}
