using ExamDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDB.Interfaces
{
    public interface IClientDBOperations
    {
        Task<ClientEntity> AddClient(ClientEntity client);
        Task<ClientEntity> UpdateClient(ClientEntity client);
        Task DeleteClient(ClientEntity client);
        Task<List<ClientEntity>> GetAllClients();
        Task<ClientEntity> GetClientById(int id);

    }
}
