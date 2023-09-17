using System.Threading.Tasks;
using Tarteeb.Api.Models.Teams;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial interface IStorageBroker_Teams
    {
        ValueTask<Team> InsertTeamAsync(Team team);
    }
}
