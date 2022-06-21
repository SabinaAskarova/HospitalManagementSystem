using HospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HospitalManagementSystem.DAL.IRepositories
{
    public interface IClientRepository
    {
        
        public Client Add(Client client);
        public void Delete(int id);
    }
}
