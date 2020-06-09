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

            ctx.Clients.Add(new Client { FirstName = clientBl.FirstName, LastName = clientBl.LastName, Telephone = clientBl.Telephone });

            ctx.SaveChanges();
        }

        public static void AddPet(PetBL pet)
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");

            var cl = ctx.Clients.ToList();

            cl[0].Pets.Add(new Pet { PetName = pet.PetName, Type = pet.Type });

            ctx.SaveChanges();
        }

        public static void AddWaybill(IndividualWaybillBL waybillBL)
        {
            var ctx = new ClientsContext(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=VetClinic2;Integrated Security=True");

            var clientsList = ctx.Clients.ToList();

            clientsList[0].IndividualWaybills.Add(new IndividualWaybill { TotalAmount = waybillBL.TotalAmount });

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
