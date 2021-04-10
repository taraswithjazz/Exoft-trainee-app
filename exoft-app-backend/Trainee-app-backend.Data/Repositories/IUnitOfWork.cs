using System;
using System.Threading;
using System.Threading.Tasks;
using Trainee_app_backend.Data.Entities;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public interface IUnitOfWork
    {
        GenericRepository<Achievement> AchievementRepository { get; }
        GenericRepository<User> UserRepository { get; }

        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}
