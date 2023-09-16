//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Local = Tarteeb.Api.Models.Tasks;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Local.Task> Tasks { get; set; }

        public async ValueTask<Local.Task> InsertTaskAsync(Local.Task task) =>
            await InsertAsync(task);

        public IQueryable<Local.Task> SelectAllTasks() =>
            SelectAll<Local.Task>();

        public async ValueTask<Local.Task> UpdateTaskAsync(Local.Task task) =>
            await UpdateAsync(task);

        public async ValueTask<Local.Task> DeleteTaskAsync(Local.Task task) =>
            await DeleteAsync<Local.Task>(task);
    }
}
