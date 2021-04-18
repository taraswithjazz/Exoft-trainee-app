using System;
using System.Collections.Generic;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
