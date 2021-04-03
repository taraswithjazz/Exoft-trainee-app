using System;
using System.Collections.Generic;
using System.Linq;
using Trainee_app_backend.Data;
using TraineeAppBackend.Data.Entities;

namespace TraineeAppBackend.Data.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {
        private readonly gmfctnContext _context;
        public AchievementRepository(gmfctnContext context)
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
    }
}
