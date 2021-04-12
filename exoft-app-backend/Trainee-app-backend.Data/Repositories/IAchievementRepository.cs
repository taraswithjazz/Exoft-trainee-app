using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Trainee_app_backend.Data.DTOs;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Repositories
{
    public interface IAchievementRepository
    {
        public Task<IEnumerable<Achievement>> GetAllAchievements(CancellationToken cancellationToken);
        public Task<Achievement> GetAchievementById(Guid id, CancellationToken cancellationToken);
        public Task CreateAchievement(Achievement achievement, CancellationToken cancellationToken);
        public Task DeleteAchievement(Guid id, CancellationToken cancellationToken);
        public void UpdateAchievement(Achievement achievement);
    }
}
