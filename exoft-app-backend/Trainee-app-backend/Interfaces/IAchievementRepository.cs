using System;
using System.Collections.Generic;
using Trainee_app_backend.Models;

namespace Trainee_app_backend.Interfaces
{
    public interface IAchievementRepository
    {
        public IEnumerable<Achievement> GetAllAchievements();
        public Achievement GetAchievementById(int id);
    }
}
