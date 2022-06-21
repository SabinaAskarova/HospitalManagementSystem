using HospitalManagementSystem.DAL.DataContext;
using HospitalManagementSystem.DAL.IRepositories;
using HospitalManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagementSystem.DAL.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly TestDbContext _ctx;
        public DoctorRepository(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public Doctor Add(Doctor doctor)
        {
            _ctx.Doctors.Add(doctor);
            _ctx.SaveChanges();
            return doctor;
        }

        public void Delete(int id)
        {
            Doctor doctor = _ctx.Doctors.Find(id);
            doctor.IsDeleted = true;
            _ctx.SaveChanges();
        }

        public List<Doctor> Get()
        {
            return _ctx.Doctors.OrderBy(m => m.Id).ToList();
        }

        public Doctor GetById(int id)
        {
            Doctor doctor = _ctx.Doctors.Find(id);
            return doctor;
        }

        public Doctor Update(Doctor doctor)
        {
            _ctx.Doctors.Update(doctor);
            _ctx.SaveChanges();
            return doctor;
        }
    }
}
