namespace Utils.Models
{
    public class PetR
    {
        public string PetName { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public virtual ClientR Client { get; set; }
        public int ClientId { get; set; }
    }
}
