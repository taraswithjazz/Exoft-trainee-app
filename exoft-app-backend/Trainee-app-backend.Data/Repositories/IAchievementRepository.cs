using System;
using System.Collections.Generic;
using Trainee_app_backend.Data.DTOs;
using TraineeAppBackend.Data.Entities;

namespace TraineeAppBackend.Data.Repositories
{
    public interface IAchievementRepository
    {
        public IEnumerable<Achievement> GetAllAchievements();
        public Achievement GetAchievementById(Guid id);
        public void CreateAchievement(AchievementCreateDTO achievementCreateDTO);
        public void UpdateAchievement(Guid id, AchievementUpdateDTO achievementUpdateDTO);
        public void DeleteAchievement(Guid id);
    }
}
