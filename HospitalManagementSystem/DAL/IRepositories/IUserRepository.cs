using HospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HospitalManagementSystem.DAL.IRepositories
{
    public interface IUserRepository
    {
        public List<User> Get();

        public User GetById(int userId);

        public void Delete(int userId);
    }
}
