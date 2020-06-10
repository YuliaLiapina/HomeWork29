using BusinessLayer.Models;
using ClientsDAL;
using Utils.Interfaces;
using Utils.Models;

namespace BusinessLayer
{
    public class BusinessLogic
    {
        private readonly IRepository vetclinicRepository;
        public BusinessLogic()
        {
            vetclinicRepository = new RepositoryDAL();
        }
        public void AddClient(ClientBL clientbl)
        {
            var newClient = new ClientR() { FirstName = clientbl.FirstName, LastName = clientbl.LastName, Telephone = clientbl.Telephone };

            vetclinicRepository.AddClient(newClient);
        }

        public void AddPet(PetBL petbl)
        {
            var newPet = new PetR() { PetName = petbl.PetName, Type = petbl.Type, ClientId = petbl.ClientId };

            vetclinicRepository.AddPet(newPet);
        }

        public void AddWaybill(IndividualWaybillBL waybillbl)
        {
            var newWaybill = new IndividualWaybillR() { TotalAmount = waybillbl.TotalAmount, ClientId = waybillbl.ClientId };

            vetclinicRepository.AddWaybill(newWaybill);
        }
        public void RemovingClientById(int id)
        {
            vetclinicRepository.RemovingClientById(id);
        }
        public void RemovingPetById(int id)
        {
            vetclinicRepository.RemovingPetById(id);
        }
        public void RemovingWaybillById(int id)
        {
            vetclinicRepository.RemovingWaybillById(id);
        }
        public void GetClients()
        {
            vetclinicRepository.GetClients();
        }
    }
}


