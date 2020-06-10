using BusinessLayer;
using BusinessLayer.Models;
using System;

namespace HomeWork29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vetclinicManager = new BusinessLogic();

            var newClient = new ClientBL() { FirstName = "Tom", LastName = "Krus", Telephone = "0984756874" };

            vetclinicManager.AddClient(newClient);

            var newPet = new PetBL() { PetName = "Murzik", Type = "Cat", ClientId = 13 };

            vetclinicManager.AddPet(newPet);

            var newWaybill = new IndividualWaybillBL() { TotalAmount = 100.87M, ClientId = 13 };

            vetclinicManager.AddWaybill(newWaybill);

            vetclinicManager.RemovingClientById(1);
            vetclinicManager.RemovingPetById(4);
            vetclinicManager.RemovingWaybillById(2);

            vetclinicManager.GetClients();

            Console.ReadKey();
        }
    }
}
