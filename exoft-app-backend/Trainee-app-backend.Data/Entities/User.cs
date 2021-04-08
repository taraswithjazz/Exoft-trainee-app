using System;
using System.ComponentModel.DataAnnotations;
using TraineeAppBackend.Data.Entities;

namespace Trainee_app_backend.Data.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int Xp { get; set; }
        public Guid? AvatarId { get; set; }
        public string Roles { get; set; }
        public string Achievements { get; set; }
    }
}
