namespace BusinessLayer.Models
{
    public class IndividualWaybillBL
    {
        public decimal TotalAmount { get; set; }
        public int ClientId { get; set; }
        public int Id { get; set; }
        public virtual ClientBL Client { get; set; }
    }
}
