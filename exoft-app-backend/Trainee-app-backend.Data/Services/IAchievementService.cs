using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Trainee_app_backend.Data.DTOs;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Services
{
    public interface IAchievementService
    {
        public Task<IEnumerable<Achievement>> GetAllAchievementsAsync(CancellationToken cancellationToken);
        public Task<Achievement> GetAchievementByIdAsync(Guid id, CancellationToken cancellationToken);
        public Task<Achievement> CreateAchievementAsync(AchievementCreateDTO achievement, CancellationToken cancellationToken);
        public Task DeleteAchievementAsync(Guid id, CancellationToken cancellationToken);
        public Task<Achievement> UpdateAchievementAsync(Guid id, AchievementUpdateDTO achievement, CancellationToken cancellationToken);
    }
}
