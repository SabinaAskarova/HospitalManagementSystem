using AutoMapper;
using HospitalManagementSystem.BLL.IServices;
using HospitalManagementSystem.DAL.IRepositories;
using HospitalManagementSystem.DTOs.ClientDTOs;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.BLL.Services
{
    public class ClientService: IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;
        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public ClientToListDTO Add(ClientToAddDTO clientToAddDTO)
        {
            Client client = _mapper.Map<Client>(clientToAddDTO);
            return _mapper.Map<ClientToListDTO>(_clientRepository.Add(client));
        }

        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}
