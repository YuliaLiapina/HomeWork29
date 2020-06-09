using System.Collections.Generic;

namespace ClientsDAL.Models
{
    public class Client
    {
        public Client()
        {
            Pets = new List<Pet>();
            IndividualWaybills = new List<IndividualWaybill>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public ICollection<Pet> Pets { get; set; }
        public ICollection<IndividualWaybill> IndividualWaybills { get; set; }
    }
}
