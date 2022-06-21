using HospitalManagementSystem.DTOs.UserDTOs;
using System.Collections.Generic;

namespace HospitalManagementSystem.BLL.IServices
{
    public interface IUserService
    {
        public List<UserToListDTO> Get();

        public UserToListDTO GetById(int userId);

        public void Delete(int userId);
    }
}
