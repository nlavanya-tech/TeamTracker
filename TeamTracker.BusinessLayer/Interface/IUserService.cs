using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamTracker.Entities;

namespace TeamTracker.BusinessLayer.Interface
{
   public interface IUserService
    {
        Task<IEnumerable<Users>> GetAllUserName();
        Task<IEnumerable<Users>> UserReadAsync();
        Task<Users> UserCreateAsync(Users user);
        Task<Users> UserUpdateAsync(Users user);
        Task<bool> UserDeleteAsync(Users user);
    }
}
