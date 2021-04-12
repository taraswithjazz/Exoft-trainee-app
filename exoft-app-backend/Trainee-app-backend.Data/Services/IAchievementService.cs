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
        public Task<IEnumerable<Achievement>> GetAllAchievements(CancellationToken cancellationToken);
        public Task<Achievement> GetAchievementById(Guid id, CancellationToken cancellationToken);
        public Task<Achievement> CreateAchievement(AchievementCreateDTO achievement, CancellationToken cancellationToken);
        public Task DeleteAchievement(Guid id, CancellationToken cancellationToken);
        public Task<Achievement> UpdateAchievement(Guid id, AchievementUpdateDTO achievement, CancellationToken cancellationToken);
    }
}
