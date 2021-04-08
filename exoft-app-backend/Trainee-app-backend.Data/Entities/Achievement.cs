﻿using System;
using System.ComponentModel.DataAnnotations;
using Trainee_app_backend.Data.Validators;

namespace TraineeAppBackend.Data.Entities
{
    public class Achievement : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Xp { get; set; }
        [Required]
        public Guid IconId { get; set; }
    }
}
