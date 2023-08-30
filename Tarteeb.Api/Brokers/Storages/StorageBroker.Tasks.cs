using Microsoft.EntityFrameworkCore;
namespace Tarteeb.Api.Models.Tasks
{
    public partial class StorageBroker
    {
        public DbSet<Task> Tasks { get; set; }
    }
}
