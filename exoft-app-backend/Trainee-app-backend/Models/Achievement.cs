﻿using System;
namespace TraineeAppBackend.Models
{
    public class Achievement : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Xp { get; set; }
        public int IconId { get; set; }
    }
}
