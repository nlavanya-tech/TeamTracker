using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamTracker.BusinessLayer.Interface;
using TeamTracker.BusinessLayer.Services.Repository;
using TeamTracker.Entities;

namespace TeamTracker.BusinessLayer.Services
{
   public class TeamService : ITeamService
    {
        //create local instance 
        private readonly ITeamRepository _repositary;

        public TeamService(ITeamRepository repositary)
        {
            _repositary = repositary;
        }

        //Get teams and retrun list of teams
        public async Task<IEnumerable<Teams>> TeamReadAsync()
        {
            var teams = await _repositary.TeamReadAsync();
            return teams;
        }
        //Create teams
        public async Task<Teams> TeamCreateAsync(Teams teams)
        {
            await _repositary.TeamCreateAsync(teams);
            return teams;
        }
        //Update teams
        public async Task<Teams> TeamUpdateAsync(Teams teams)
        {
            var note = await _repositary.TeamUpdateAsync(teams);

            return note;
        }
        //Delete teams 
        public async Task<bool> TeamDeleteAsync(Teams teams)
        {
            var result = await _repositary.TeamDeleteAsync(teams);
            return result;
        }
    }
}
