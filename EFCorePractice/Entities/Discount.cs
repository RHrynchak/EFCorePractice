namespace EFCorePractice.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Percentage { get; set; }
        public bool IsForLoyalClients { get; set; }
        public ICollection<Sale> Sales { get; set; } // Navigation property
    }
}