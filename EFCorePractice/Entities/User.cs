using EFCorePractice.Enums;

namespace EFCorePractice.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public UserRole Role { get; set; }
        public int? BonusPoints { get; set; }
        public ICollection<Sale> Sales { get; set; } // Navigation property
    }
}