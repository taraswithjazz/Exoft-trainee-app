using System;
using System.Collections.Generic;
using System.Linq;
using TraineeAppBackend.Data.Entities;

namespace TraineeAppBackend.Data.Repositories
{
    public class AchievementRepository : IAchievementRepository
    {

        public List<Achievement> achievements = new List<Achievement>(){
            new Achievement {
             Name = "Exoft Turbo Power",
             Description = "Granted for coding fast",
             Xp = 15,
             IconId = 1322,
             Id = new Guid("11111111-1111-1111-1111-111111111111")
            },
            new Achievement {
             Name = "Exoft Turbo Power",
             Description = "Granted for coding fast",
             Xp = 15,
             IconId = 1322,
             Id = new Guid("11111111-1111-1111-1111-111111111112")
            }
        };

        public IEnumerable<Achievement> GetAllAchievements()
        {
            return achievements;
        }

        public Achievement GetAchievementById(Guid id)
        {
            return achievements.FirstOrDefault(e => e.Id == id);
        }
    }
}
