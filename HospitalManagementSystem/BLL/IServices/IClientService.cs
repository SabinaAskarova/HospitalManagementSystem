using HospitalManagementSystem.DTOs.ClientDTOs;
using System.Collections.Generic;

namespace HospitalManagementSystem.BLL.IServices
{
    public interface IClientService
    {

        public ClientToListDTO Add(ClientToAddDTO clientToAddDTO);

        public void Delete(int id);
    }
}
