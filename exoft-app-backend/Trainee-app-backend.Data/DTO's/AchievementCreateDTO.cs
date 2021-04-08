using System;
using System.ComponentModel.DataAnnotations;
using Trainee_app_backend.Data.Validators;

namespace Trainee_app_backend.Data.DTOs
{
    public class AchievementCreateDTO
    {
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        [Required]
        [GreaterThanZero]
        public int Xp { get; set; }
        [Required]
        public Guid IconId { get; set; }
    }
}
