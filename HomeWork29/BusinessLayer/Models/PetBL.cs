namespace BusinessLayer.Models
{
    public class PetBL
    {
        public string PetName { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public virtual ClientBL Client { get; set; }
        public int ClientId { get; set; }
    }
}
