using System;
using System.Collections.Generic;
using TraineeAppBackend.Data.Entities;

namespace TraineeAppBackend.Data.Repositories
{
    public interface IAchievementRepository
    {
        public IEnumerable<Achievement> GetAllAchievements();
        public Achievement GetAchievementById(Guid id);
        public void CreateAchievement(Achievement achievement);
        public void UpdateAchievement(Guid id, Achievement achievement);
        public void DeleteAchievement(Guid id);
    }
}
