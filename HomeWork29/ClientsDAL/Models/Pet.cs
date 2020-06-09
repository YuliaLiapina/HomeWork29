namespace ClientsDAL.Models
{
    public class Pet
    {
        public string PetName { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }
    }
}
