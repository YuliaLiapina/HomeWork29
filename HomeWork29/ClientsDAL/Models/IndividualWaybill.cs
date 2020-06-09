namespace ClientsDAL.Models
{
    public class IndividualWaybill
    {
        public int Id { get; set; }
        public decimal TotalAmount { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
