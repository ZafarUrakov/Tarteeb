using System;
using System.Linq;
using System.Threading.Tasks;
using Tarteeb.Api.Models.Teams;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial interface IStorageBroker_Teams
    {
        ValueTask<Team> InsertTeamAsync(Team team);
        IQueryable<Team> SelectAllTeam();
        ValueTask<Team> SelectTeamById(Guid id);
        ValueTask<Team> UpdateTeamAsync(Team team);
        ValueTask<Team> DeleteTeamAsync(Team team);
    }
}
