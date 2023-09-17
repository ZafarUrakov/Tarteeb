//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Tarteeb.Api.Models.Teams;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Team> Teams { get; set; }

        public async ValueTask<Team> InsertTeamAsync(Team team) =>
            await InsertAsync(team);
        public IQueryable<Team> SelectAllTeam() =>
            SelectAll<Team>();
        public async ValueTask<Team> SelecTeamById(Guid id) =>
            await SelectAsync<Team>(id);
        public async ValueTask<Team> UpdateTeamAsync(Team team) =>
            await UpdateAsync(team);
        public async ValueTask<Team> DeleteTeamAsync(Team team) =>
            await DeleteAsync(team);
    }
}
