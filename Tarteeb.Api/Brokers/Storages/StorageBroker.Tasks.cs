//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Local = Tarteeb.Api.Models.Tasks;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Local.Task> Tasks { get; set; }

        public async ValueTask<Local.Task> InsertTaskAsync(Local.Task task) =>
            await InsertAsync(task);

        public IQueryable<Local.Task> SelectAllTask() =>
            SelectAllAsync<Local.Task>();
    }
}
