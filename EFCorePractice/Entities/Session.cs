using EFCorePractice.Enums;

namespace EFCorePractice.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public int MovieId { get; set; } // Foreign key
        public Movie Movie { get; set; } // Navigation property
        public int HallId { get; set; } // Foreign key
        public Hall Hall { get; set; } // Navigation property
        public DateTime StartTime { get; set; }
        public decimal TicketPrice { get; set; }
        public SessionStatus Status { get; set; }
        public ICollection<Ticket> Tickets { get; set; } // Navigation property
    }
}