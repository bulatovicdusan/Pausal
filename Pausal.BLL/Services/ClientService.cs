using Pausal.BLL.Interfaces;
using Pausal.BLL.Model;
using Pausal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _context;
        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task CreateClient(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public Task<List<ClientModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserByIdentificationNumber(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserByPIB(int pib)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveClient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
