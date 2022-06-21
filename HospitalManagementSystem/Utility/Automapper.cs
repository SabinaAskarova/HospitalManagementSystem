using AutoMapper;
using HospitalManagementSystem.DTOs.ClientDTOs;
using HospitalManagementSystem.DTOs.DoctorDTOs;
using HospitalManagementSystem.DTOs.UserDTOs;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Utility
{
    public class Automapper:Profile
    {
        public Automapper()
        {
            CreateMap<UserToAddDTO,User>().ReverseMap();
            CreateMap<UserToUpdateDTO, User>().ReverseMap();
            CreateMap<User, UserToListDTO>().ReverseMap();

            CreateMap<DoctorToAddDTO, Doctor>().ReverseMap();
            CreateMap<DoctorToUpdateDTO, Doctor>().ReverseMap();
            CreateMap<Doctor, DoctorToListDTO>().ReverseMap();

            CreateMap<ClientToAddDTO, Client>().ReverseMap();
        }
    }
}
