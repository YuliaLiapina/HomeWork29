using BusinessLayer;
using BusinessLayer.Models;
using System;

namespace HomeWork29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var newClient = new ClientBL() { FirstName = "Alen", LastName = "Delon", Telephone = "05736475882" };
            BusinessLogic.AddClient(newClient);

            var newPet = new PetBL() { PetName = "Bobik", Type = "Dog" };
            BusinessLogic.AddPet(newPet,2);

            var newWaybill = new IndividualWaybillBL() { TotalAmount = 200.87M, ClientId = 1 };
            BusinessLogic.AddWaybill(newWaybill,3);

            BusinessLogic.RemovingClientById(5);
            BusinessLogic.RemovingPetById(6);
            BusinessLogic.RemovingWaybillById(2);

            BusinessLogic.GetClients();

            Console.ReadKey();
        }
    }
}
