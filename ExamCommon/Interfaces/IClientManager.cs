using ExamCommon.Models;

namespace ExamCommon.Interfaces
{
    public interface IClientManager
    {
        Task<Client> AddClient(Client client);
        Task<Client> UpdateClient(Client client);
        Task DeleteClient(Client client);
        Task<List<Client>> GetAllClients();
        Task<Client> GetClientById(int id);
    }
}
