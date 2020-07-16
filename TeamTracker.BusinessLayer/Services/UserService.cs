using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamTracker.BusinessLayer.Interface;
using TeamTracker.BusinessLayer.Services.Repository;
using TeamTracker.Entities;

namespace TeamTracker.BusinessLayer.Services
{
  public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        //Get all Usernames 
        public async Task<IEnumerable<Users>> GetAllUserName()
        {
            var users = await _repository.GetAllUserName();

            return users;
        }
        //Get =user and retrun list of users
        public async Task<IEnumerable<Users>> UserReadAsync()
        {
            var users = await _repository.UserReadAsync();
            return users;
        }
        //Create teams
        public async Task<Users> UserCreateAsync(Users user)
        {
            await _repository.UserCreateAsync(user);
            return user;
        }
        //Update teams
        public async Task<Users> UserUpdateAsync(Users user)
        {
            var users = await _repository.UserUpdateAsync(user);

            return users;
        }
        //Delete teams 
        public async Task<bool> UserDeleteAsync(Users user)
        {
            var result = await _repository.UserDeleteAsync(user);
            return result;
        }
    }
}
