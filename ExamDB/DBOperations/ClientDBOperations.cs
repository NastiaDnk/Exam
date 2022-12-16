using ExamDB.Interfaces;
using ExamDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDB.DBOperations
{
    public class ClientDBOperations : IClientDBOperations
    {
        private DBContext GetDBContext()
        {
            return new DBContext();
        }

        public async Task<ClientEntity> AddClient(ClientEntity client)
        {
            using(DBContext dbContext = GetDBContext())
            {
                dbContext.Client.Add(client);
                await dbContext.SaveChangesAsync();
                return client;
            }
        }

        public async Task DeleteClient(ClientEntity client)
        {
            using(DBContext dbContext = GetDBContext())
            {
                dbContext.Client.Remove(client);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<ClientEntity>> GetAllClients()
        {
            using(DBContext dbContext = GetDBContext())
            {
                return dbContext.Client.ToList();
            }
        }

        public async Task<ClientEntity> GetClientById(int id)
        {
            using (DBContext dbContext = GetDBContext())
            {
                return dbContext.Client.First(cl => cl.Id == id);
            }
        }

        public async Task<ClientEntity> UpdateClient(ClientEntity client)
        {
            using (DBContext dbContext = GetDBContext())
            {
                dbContext.Client.Update(client);
                await dbContext.SaveChangesAsync();
                return client;
            }
        }
    }
}
