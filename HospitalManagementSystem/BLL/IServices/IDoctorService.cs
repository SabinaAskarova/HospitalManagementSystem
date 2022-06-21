using HospitalManagementSystem.DTOs.DoctorDTOs;
using System.Collections.Generic;

namespace HospitalManagementSystem.BLL.IServices
{
    public interface IDoctorService
    {
        public List<DoctorToListDTO> Get();

        public DoctorToListDTO GetById(int id);

        public DoctorToListDTO Add(DoctorToAddDTO doctorToAddDTO);

        public DoctorToListDTO Update(DoctorToUpdateDTO doctorToUpdateDTO);

        public void Delete(int id);
    }
}
