using HospitalManagementSystem.DAL.DataContext;
using HospitalManagementSystem.DAL.IRepositories;
using HospitalManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagementSystem.DAL.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly TestDbContext _ctx;
        public ClientRepository(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public Client Add(Client client)
        {
           _ctx.Clients.Add(client);
            _ctx.SaveChanges();
            return client;
        }

        public void Delete(int id)
        {
            Client client = _ctx.Clients.Find(id);
            client.IsDeleted = true;
            _ctx.SaveChanges();
        }

        
    }
}
