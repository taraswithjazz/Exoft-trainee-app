using System;
using System.ComponentModel.DataAnnotations;
using Trainee_app_backend.Data.Entities;

namespace Trainee_app_backend.Data.DTOs
{
    public class UserUpdateDTO
    {
        [Required]
        [StringLength(32)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(32)]
        public string LastName { get; set; }
        [Required]
        [StringLength(250)]
        [EmailAddress]
        public string Email { get; set; }
        [StringLength(250)]
        public string Status { get; set; }
        [Required]
        public UserRole[] Roles { get; set; }
        [Required]
        [StringLength(32)]
        public string UserName { get; set; }
    }
}
