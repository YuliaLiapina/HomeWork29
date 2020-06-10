using System.Collections.Generic;

namespace Utils.Models
{
    public class ClientR
    {
        public ClientR()
        {
            Pets = new List<PetR>();
            IndividualWaybills = new List<IndividualWaybillR>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public ICollection<PetR> Pets { get; set; }
        public ICollection<IndividualWaybillR> IndividualWaybills { get; set; }
    }
}
