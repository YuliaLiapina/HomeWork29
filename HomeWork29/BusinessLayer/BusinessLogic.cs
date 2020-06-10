using BusinessLayer.Models;
using ClientsDAL;
using ClientsDAL.Models;
using System;
using System.Linq;

namespace BusinessLayer
{
    public class BusinessLogic
    {
        public static void AddClient(ClientBL clientBl)
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");

            var newClient = new Client() { FirstName = clientBl.FirstName, LastName = clientBl.LastName, Telephone = clientBl.Telephone });

            ctx.Clients.Add(newClient);

            ctx.SaveChanges();
        }

        public static void AddPet(PetBL pet, int idClient)
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");

            var clients = ctx.Clients.ToList();

            var newPet = new Pet() { PetName = pet.PetName, Type = pet.Type };

            if (idClient > 0 && idClient < clients.Count)
            {
                clients[idClient - 1].Pets.Add(newPet);
            }
            else
            {
                Console.WriteLine($"Incorrect! A client with id {idClient} does not exist");
            }

            ctx.SaveChanges();
        }

        public static void AddWaybill(IndividualWaybillBL waybillBL, int idClient)
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");

            var clients = ctx.Clients.ToList();

            var newWaybill = new IndividualWaybill() { TotalAmount = waybillBL.TotalAmount };

            if (idClient > 0 && idClient < clients.Count)
            {
                clients[0].IndividualWaybills.Add(newWaybill);
            }
            else
            {
                Console.WriteLine($"Incorrect! A client with id {idClient} does not exist");
            }

            ctx.SaveChanges();
        }

        public static void RemovingClientById(int id)
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");

            var client = ctx.Clients.Where(x => x.Id == id).FirstOrDefault();

            ctx.Clients.Remove(client);

            ctx.SaveChanges();
        }
        public static void RemovingPetById(int id)
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");

            var pet = ctx.Pets.Where(x => x.Id == id).FirstOrDefault();

            ctx.Pets.Remove(pet);

            ctx.SaveChanges();
        }
        public static void RemovingWaybillById(int id)
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");

            var wayBill = ctx.IndividualWaybills.Where(x => x.Id == id).FirstOrDefault();

            ctx.IndividualWaybills.Remove(wayBill);

            ctx.SaveChanges();
        }

        public static void GetClients()
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");
            var clients = ctx.Clients.ToList();

            foreach (var item in clients)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }
    }
}

