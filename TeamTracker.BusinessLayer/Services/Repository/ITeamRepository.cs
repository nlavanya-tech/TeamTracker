using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TeamTracker.Entities;

namespace TeamTracker.BusinessLayer.Services.Repository
{
  public interface ITeamRepository
    {
        Task<IEnumerable<Teams>> TeamReadAsync();
        Task<Teams> TeamCreateAsync(Teams teams);
        Task<Teams> TeamUpdateAsync(Teams teams);
        Task<bool> TeamDeleteAsync(Teams teams);
    }
}
