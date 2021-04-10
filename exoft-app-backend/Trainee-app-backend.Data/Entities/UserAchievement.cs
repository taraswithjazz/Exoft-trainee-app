using System;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Entities
{
    public class UserAchievement : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Achievement Achievement { get; set; }
        public DateTime AddedTime { get; set; }
        public Guid AchievementId { get; set; }
    }
}
