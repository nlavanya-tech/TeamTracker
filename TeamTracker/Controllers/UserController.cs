using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamTracker.BusinessLayer.Interface;
using TeamTracker.Entities;

namespace TeamTracker.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userservice;
        public UserController(IUserService userservice)
        {
            this.userservice = userservice;
        }
        public async Task<IActionResult> GetUserDetails()
        {
            var list = await userservice.UserReadAsync();
            return View(list);
        }
        public async Task<IActionResult> CreateUser(Users users)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(Users users)
        {
            await userservice.UserCreateAsync(users);
            return RedirectToAction("GetUserDetails", "User");
        }
        [HttpGet]
        public async Task<IActionResult> EditUsers()
        {
            return View();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser(Users user)
        {
            await userservice.UserUpdateAsync(user);
            return RedirectToAction("GetUserDetails", "User");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteUser(Users user)
        {
            await userservice.UserDeleteAsync(user);
            return RedirectToAction("GetUserDetails", "User");
        }
    }
}