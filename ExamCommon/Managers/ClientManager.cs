using AutoMapper;
using ExamCommon.Interfaces;
using ExamCommon.Models;
using ExamDB.Interfaces;
using ExamDB.Models;

namespace ExamCommon.Managers
{
    public class ClientManager : IClientManager
    {
        private readonly IMapper _mapper;
        private readonly IClientDBOperations _clientRepository;
        public ClientManager(IMapper mapper, IClientDBOperations clientDBOperations)
        {
            _mapper = mapper;
            _clientRepository = clientDBOperations;
        }
        public async Task<Client> AddClient(Client client)
        {
            var result = await _clientRepository.AddClient(_mapper.Map<ClientEntity>(client));
            return _mapper.Map<Client>(result);
        }

        public async Task DeleteClient(Client client)
        {
            await _clientRepository.DeleteClient(_mapper.Map<ClientEntity>(client));
        }

        public async Task<List<Client>> GetAllClients()
        {
            return (await _clientRepository.GetAllClients())
                .Select(x => _mapper.Map<Client>(x)).ToList();
        }

        public async Task<Client> GetClientById(int id)
        {
            return _mapper.Map<Client>(await _clientRepository.GetClientById(id));
        }

        public async Task<Client> UpdateClient(Client client)
        {
            return _mapper.Map<Client>((await _clientRepository.UpdateClient(_mapper.Map<ClientEntity>(client))));
        }
    }
}
