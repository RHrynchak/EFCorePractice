namespace EFCorePractice.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key
        public User User { get; set; } // Navigation property
        public DateTime PurchaseDate { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<Ticket> Tickets { get; set; } // Navigation property
        public int? DiscountId { get; set; } // Foreign key
        public Discount? Discount { get; set; } // Navigation property
    }
}