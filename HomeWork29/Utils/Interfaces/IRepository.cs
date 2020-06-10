using Utils.Models;

namespace Utils.Interfaces
{
    public interface IRepository
    {
        void AddClient(ClientR client);
        void AddPet(PetR pet);
        void AddWaybill(IndividualWaybillR waybillBL);
        void RemovingClientById(int id);
        void RemovingPetById(int id);
        void RemovingWaybillById(int id);
        void GetClients();
    }
}
