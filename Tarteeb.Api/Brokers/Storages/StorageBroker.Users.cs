using Microsoft.EntityFrameworkCore;
using Tarteeb.Models.Users;

namespace Tarteeb.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<User> Users { get; set; }
    }
}