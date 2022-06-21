using AutoMapper;
using HospitalManagementSystem.BLL.IServices;
using HospitalManagementSystem.DAL.IRepositories;
using HospitalManagementSystem.DTOs.DoctorDTOs;
using HospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HospitalManagementSystem.BLL.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;
        public DoctorService(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        public DoctorToListDTO Add(DoctorToAddDTO doctorToAddDTO)
        {
            Doctor doctor = _mapper.Map<Doctor>(doctorToAddDTO); ;
            return _mapper.Map<DoctorToListDTO>(_doctorRepository.Add(doctor)); 
        }

        public void Delete(int id)
        {
            _doctorRepository.Delete(id);
        }

        public List<DoctorToListDTO> Get()
        {
            return _mapper.Map<List<DoctorToListDTO>>(_doctorRepository.Get());
        }

        public DoctorToListDTO GetById(int id)
        {
            return _mapper.Map<DoctorToListDTO>(_doctorRepository.GetById(id));
        }

        public DoctorToListDTO Update(DoctorToUpdateDTO doctorToUpdateDTO)
        {
            Doctor doctor = _mapper.Map<Doctor>(doctorToUpdateDTO); ;
            return _mapper.Map<DoctorToListDTO>(_doctorRepository.Update(doctor));
        }
    }
}
