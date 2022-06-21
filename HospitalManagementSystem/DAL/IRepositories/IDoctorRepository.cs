using HospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HospitalManagementSystem.DAL.IRepositories
{
    public interface IDoctorRepository
    {
        public List<Doctor> Get();

        public Doctor GetById(int id);

        public Doctor Add(Doctor doctor);

        public Doctor Update(Doctor doctor);

        public void Delete(int id);
    }
}
