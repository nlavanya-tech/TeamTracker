using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamTracker.DataLayer;
using TeamTracker.Entities;

namespace TeamTracker.BusinessLayer.Services.Repository
{
  public class TeamRepository : ITeamRepository
    {
        private InMemoryDatabase DbContext;
        public TeamRepository(InMemoryDatabase DbContext)
        {
            this.DbContext = DbContext;
        }

        public async Task<IEnumerable<Teams>> TeamReadAsync()
        {
            var teams = this.DbContext.teams.ToList();
            return teams;
        }
        //Add team into Inmemory Db and return teams
        public async Task<Teams> TeamCreateAsync(Teams teams)
        {
            this.DbContext.Add(teams);
            this.DbContext.SaveChanges();
            return teams;
        }
        //Update team into Inmemory Db and return teams 
        public async Task<Teams> TeamUpdateAsync(Teams teams)
        {
            var notes = this.DbContext.teams.FirstOrDefault(e => e.TeamName == teams.TeamName);
            if (notes != null)
            {
                teams.TeamName = teams.TeamName;
                teams.TeamMembers = teams.TeamMembers;
                teams.TeamManager = teams.TeamManager;
                this.DbContext.SaveChanges();
            }
            else
            {
                teams = null;
            }
            return teams;
        }
        //Delete team from INmemory Db and return teams
        public async Task<bool> TeamDeleteAsync(Teams teams)
        {
            var team = this.DbContext.teams.FirstOrDefault(e => e.TeamName == teams.TeamName);
            if (team != null)
            {
                this.DbContext.Remove(teams.TeamName);
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
