using System;

namespace TraineeAppBackend.Data.Entities
{
    public class Achievement : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Xp { get; set; }
        public Guid IconId { get; set; }
    }
}
