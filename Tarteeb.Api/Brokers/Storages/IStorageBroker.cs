using System.Threading.Tasks;
using Local = Tarteeb.Api.Models.Tasks;

namespace Tarteeb.Api.Brokers.Storages;

public partial interface IStorageBroker
{
    ValueTask<Local.Task> InsertTaskAsync(Local.Task task);
}