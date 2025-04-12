using EFCorePractice.Enums;

namespace EFCorePractice.Entities
{
    public class Hall
    {
        public int Id { get; set; } 
        public int Number { get; set; } 
        public int Capacity { get; set; }
        public HallType Type { get; set; }
        public ICollection<Session> Sessions { get; set; } // Navigation property
    }
}