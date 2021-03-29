using System;
using System.Collections.Generic;
using System.Linq;
using TraineeAppBackend.Interfaces;
using TraineeAppBackend.Models;

namespace TraineeAppBackend.Repositories
{
        public class AchievementRepository : IAchievementRepository
        {
            List<Achievement> achievements = new List<Achievement>(){
            new Achievement{ Name = "Exoft Turbo Power",Description = "Granted for coding fast", Xp = 15 ,IconId = 1322,Id=1 },
            new Achievement{ Name = "Exoft Turbo Power",Description = "Granted for coding fast", Xp = 25 ,IconId = 1123,Id=2 }
        };

            public IEnumerable<Achievement> GetAllAchievements()
            {
                return achievements;
            }
            public Achievement GetAchievementById(int id)
            {
                return achievements.FirstOrDefault(e => e.Id == id);
            }
        }
}
