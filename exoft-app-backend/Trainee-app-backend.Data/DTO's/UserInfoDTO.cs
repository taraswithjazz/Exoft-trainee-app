using System;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.DTOs
{
    public class UserInfoDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public int Xp { get; set; }
        public Guid? AvatarId { get; set; }
        public UserRole[] Roles { get; set; }
        public UserAchievement[] Achievements { get; set; }
    }
}
