using System;
using System.Collections.Generic;
using TraineeAppBackend.Models;

namespace TraineeAppBackend.Interfaces
{
    public interface IAchievementRepository
    {
        public IEnumerable<Achievement> GetAllAchievements();
        public Achievement GetAchievementById(int id);
    }
}
