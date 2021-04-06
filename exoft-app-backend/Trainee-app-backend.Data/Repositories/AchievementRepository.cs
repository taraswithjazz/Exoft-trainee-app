using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Trainee_app_backend.Data;
using TraineeAppBackend.Data.Entities;

namespace TraineeAppBackend.Data.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {
        private readonly GmfctnContext _context;
        public AchievementRepository(GmfctnContext context)
        {
            _context = context;
        }

        public IEnumerable<Achievement> GetAllAchievements()
        {
            return _context.Achievements;
        }

        public Achievement GetAchievementById(Guid id)
        {
            return _context.Achievements.FirstOrDefault(e => e.Id == id);
        }

        public void CreateAchievement(Achievement achievement)
        {
            _context.Achievements.Add(achievement);
            _context.SaveChanges();
        }
        public void UpdateAchievement(Guid id, Achievement achievement)
        {
            var achievementFound = GetAchievementById(id);
            achievementFound.Name = achievement.Name;
            achievementFound.Description = achievement.Description;
            achievementFound.Xp = achievement.Xp;

            _context.SaveChanges();
        }
        public void DeleteAchievement(Guid id)
        {
            var achievement = _context.Achievements.Find(id);
            if (achievement != null)
            {
                _context.Achievements.Remove(achievement);
            }
            _context.SaveChanges();
        }
    }
}
