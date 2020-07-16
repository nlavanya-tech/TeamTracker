using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeamTracker.BusinessLayer.Interface;
using TeamTracker.BusinessLayer.Services;
using TeamTracker.Entities;

namespace TeamTracker.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService teamservice;
        private readonly IUserService _UserService;
        public TeamController(ITeamService teamservice)
        {
            this.teamservice = teamservice;
           // _UserService = userservice;
        }
        public async Task<IActionResult> GetTeamsDetails()
        {
            var list = await teamservice.TeamReadAsync();
            return View(list);
        }
        //[HttpGet]
        //public async Task<IActionResult> CreateTeam()
        //{
        //     var users = await _UserService.GetAllUsersNames();
             
        //  //  ViewBag.userlist = users;

        //    return View();
        //}
        //[HttpPost]
        public async Task<IActionResult> CreateTeam(Teams teams)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTeam(Teams teams)
        {
            await teamservice.TeamCreateAsync(teams);
            return RedirectToAction("GetTeamsDetails", "Team");
        }
        [HttpGet]
        public async Task<IActionResult> EditTeam()
        {
            return View();
        }
       [HttpPut]
        public async Task<IActionResult> UpdateTeam(Teams teams)
        {
            await teamservice.TeamUpdateAsync(teams);
            return RedirectToAction("GetTeamsDetails", "Team");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTeam(Teams teams)
        {
            await teamservice.TeamDeleteAsync(teams);
            return RedirectToAction("GetTeamsDetails", "Team");
        }


    }
}