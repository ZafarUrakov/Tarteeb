//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tarteeb.Api.Models.Teams;
using Tarteeb.Api.Brokers.Storages;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Team> Teams { get; set; }

        public async ValueTask<Team> InsertTaskAsync(Team team) =>
            await InsertAsync(team);
    }
}
