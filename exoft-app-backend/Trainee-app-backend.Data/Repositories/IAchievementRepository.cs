using System;
using System.Collections.Generic;
using TraineeAppBackend.Data.Entities;

namespace TraineeAppBackend.Data.Repositories
{
    public interface IAchievementRepository
    {
        public IEnumerable<Achievement> GetAllAchievements();
        public Achievement GetAchievementById(Guid id);
    }
}
