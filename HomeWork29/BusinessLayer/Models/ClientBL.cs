using System.Collections.Generic;

namespace BusinessLayer.Models
{
    public class ClientBL
    {
        public ClientBL(/*string clientFirstName, string clientLastName, string telephone*/)
        {
            Pets = new List<PetBL>();
            IndividualWaybills = new List<IndividualWaybillBL>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public ICollection<PetBL> Pets { get; set; }
        public ICollection<IndividualWaybillBL> IndividualWaybills { get; set; }
    }
}
