using ClientsDAL.Models;
using System.Data.Entity;

namespace ClientsDAL
{
    public class ClientsContext : DbContext
    {
        public ClientsContext(string connection) : base(connection)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<IndividualWaybill> IndividualWaybills { get; set; }
    }
}
