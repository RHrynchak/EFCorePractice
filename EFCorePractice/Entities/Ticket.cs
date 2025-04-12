using EFCorePractice.Enums;

namespace EFCorePractice.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int SessionId { get; set; } // Foreign key
        public Session Session { get; set; } // Navigation property
        public string SeatNumber { get; set; }
        public decimal Price { get; set; }
        public TicketStatus Status { get; set; }
        public int? SaleId { get; set; } // Foreign key
        public Sale? Sale { get; set; } // Navigation property
    }
}