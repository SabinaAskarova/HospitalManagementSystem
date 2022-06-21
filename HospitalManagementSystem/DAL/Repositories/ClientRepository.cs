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

        public void Delete(int id)
        {
            Client client = _ctx.Clients.Find(id);
            client.IsDeleted = true;
            _ctx.SaveChanges();
        }

        public List<Client> Get()
        {
            return _ctx.Clients.OrderBy(m => m.Id).ToList();
        }
    }
}
