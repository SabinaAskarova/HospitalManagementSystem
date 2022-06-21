using HospitalManagementSystem.DAL.DataContext;
using HospitalManagementSystem.DAL.IRepositories;
using HospitalManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagementSystem.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TestDbContext _ctx;
        public UserRepository(TestDbContext ctx)
        {
            _ctx=ctx;
        }
        public void Delete(int userId)
        {
            User user = _ctx.Users.Find(userId);
            user.IsDeleted = true;
            _ctx.SaveChanges();
        }

        public List<User> Get()
        {
            return _ctx.Users.OrderBy(m=>m.Id).ToList();
        }

        public User GetById(int userId)
        {
            User user = _ctx.Users.Find(userId);
            return user;
        }
    }
}
