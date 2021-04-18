using System;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Entities
{
    public class UserRole : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
        public Guid RoleId { get; set; }

    }
}
