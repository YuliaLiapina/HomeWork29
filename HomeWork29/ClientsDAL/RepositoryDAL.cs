using ClientsDAL.Models;
using System;
using System.Linq;
using Utils.Interfaces;
using Utils.Models;

namespace ClientsDAL
{
    public class RepositoryDAL : IRepository
    {
        private readonly ClientsContext ctx;
        public RepositoryDAL()
        {
            ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");
        }
        public void AddClient(ClientR client)
        {
            var newClient = new Client() { FirstName = client.FirstName, LastName = client.LastName, Telephone = client.Telephone };

            ctx.Clients.Add(newClient);

            ctx.SaveChanges();
        }

        public void AddPet(PetR pet)
        {
            var newPet = new Pet() { PetName = pet.PetName, Type = pet.Type, ClientId = pet.ClientId };

            ctx.Pets.Add(newPet);

            ctx.SaveChanges();
        }

        public void AddWaybill(IndividualWaybillR waybill)
        {
            var newWaybill = new IndividualWaybill() { TotalAmount = waybill.TotalAmount, ClientId = waybill.ClientId };

            ctx.IndividualWaybills.Add(newWaybill);

            ctx.SaveChanges();
        }

        public void RemovingClientById(int id)
        {
            var client = ctx.Clients.Where(x => x.Id == id).FirstOrDefault();

            ctx.Clients.Remove(client);

            ctx.SaveChanges();
        }
        public void RemovingPetById(int id)
        {
            var pet = ctx.Pets.Where(x => x.Id == id).FirstOrDefault();

            ctx.Pets.Remove(pet);

            ctx.SaveChanges();
        }
        public void RemovingWaybillById(int id)
        {
            var wayBill = ctx.IndividualWaybills.Where(x => x.Id == id).FirstOrDefault();

            ctx.IndividualWaybills.Remove(wayBill);

            ctx.SaveChanges();
        }

        public void GetClients()
        {
            var clients = ctx.Clients.ToList();

            foreach (var item in clients)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}
