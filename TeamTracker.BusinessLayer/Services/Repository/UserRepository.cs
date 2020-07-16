using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTracker.DataLayer;
using TeamTracker.Entities;

namespace TeamTracker.BusinessLayer.Services.Repository
{
   public class UserRepository : IUserRepository
    {
        private readonly InMemoryDatabase DbContext;
        public UserRepository(InMemoryDatabase DbContext)
        {
            this.DbContext = DbContext;
        }
        //Get All UserNames
        public async Task<IEnumerable<Users>> GetAllUserName()
        {
            var users = this.DbContext.users.ToList();
            //  IList<Users> userlist = new List<Users>();
            //string userlist = "";
            //foreach (var user in users)
            //{
            //    userlist.Add();

            //}
            return users;
        }
        //Get All Users details
        public async Task<IEnumerable<Users>> UserReadAsync()
        {
            var users = this.DbContext.users.ToList();
            return users;
        }
        //Add user into Inmemory Db and return user
        public async Task<Users> UserCreateAsync(Users users)
        {
            this.DbContext.Add(users);
            this.DbContext.SaveChanges();
            return users;
        }
        //Update user into Inmemory Db and return user 
        public async Task<Users> UserUpdateAsync(Users user)
        {
            var users = this.DbContext.users.FirstOrDefault(e => e.LastName == user.LastName);
            if (users != null)
            {
                users = user;
                //users.FirstName = users.FirstName;
                //users.LastName = users.LastName;
                //users.TeamManager = users.TeamManager;
                this.DbContext.SaveChanges();
            }
            else
            {
                users = null;
            }
            return users;
        }
        //Delete team from INmemory Db and return teams
        public async Task<bool> UserDeleteAsync(Users user)
        {
            var users = this.DbContext.users.FirstOrDefault(e => e.LastName == user.LastName);
            if (users != null)
            {
                this.DbContext.Remove(users.LastName);
                this.DbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
