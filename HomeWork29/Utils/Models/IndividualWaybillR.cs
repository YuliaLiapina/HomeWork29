namespace Utils.Models
{
    public class IndividualWaybillR
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public int ClientId { get; set; }
        public virtual ClientR Client { get; set; }
    }
}
