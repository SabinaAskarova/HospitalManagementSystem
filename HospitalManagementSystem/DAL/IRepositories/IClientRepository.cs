using HospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HospitalManagementSystem.DAL.IRepositories
{
    public interface IClientRepository
    {
        public List<Client> Get();

        public void Delete(int id);
    }
}
