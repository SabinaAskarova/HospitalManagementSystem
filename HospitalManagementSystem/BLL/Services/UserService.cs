using AutoMapper;
using HospitalManagementSystem.BLL.IServices;
using HospitalManagementSystem.DAL.IRepositories;
using HospitalManagementSystem.DTOs.UserDTOs;
using HospitalManagementSystem.Models;
using System.Collections.Generic;

namespace HospitalManagementSystem.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void Delete(int userId)
        {
            _userRepository.Delete(userId);
        }

        public List<UserToListDTO> Get()
        {
            return _mapper.Map<List<UserToListDTO>>(_userRepository.Get());
        }

        public UserToListDTO GetById(int userId)
        {
            User user = _userRepository.GetById(userId);
            return _mapper.Map<UserToListDTO>(user);
        }
    }
}
