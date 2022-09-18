using Microsoft.EntityFrameworkCore;
using Pausal.BLL.Interfaces;
using Pausal.BLL.Mapper;
using Pausal.BLL.Model;
using Pausal.DAL;
using Pausal.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<String> CreateUser(UserModel user)
        {
            var userExist = await _context.Users.Where(x => x.Email == user.Email || x.Username.Equals(user.Username)).Select(x => new { Email = x.Email, Username = x.Username }).FirstOrDefaultAsync();

            if (userExist != null)
            {
                if (userExist.Email.Equals(user.Email))
                {
                    return "User with same email already exist";
                }

                if (userExist.Username.Equals(user.Username))
                {
                    return "User with same username already exist";
                }
            }

            var mapped = ObjectMapper.Mapper.Map<User>(user);
            if (mapped == null)
                throw new ApplicationException($"Entity could not be mapped.");

            _context.Users.Add(mapped);
            await _context.SaveChangesAsync();

            return "OK";
        }

        public async Task<List<UserModel>> GetAll()
        {
            var users = await _context.Users.ToListAsync();

            var mapped = ObjectMapper.Mapper.Map<List<UserModel>>(users);
            return mapped;
        }

        public Task<UserModel> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Task<AuthenticateResponse> LoginAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
