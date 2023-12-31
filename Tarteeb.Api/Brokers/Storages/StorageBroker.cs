﻿//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        private readonly IConfiguration _configuration;

        public StorageBroker(IConfiguration configuration)
        {
            _configuration = configuration;
            this.Database.Migrate();
        }

        private async ValueTask<T> InsertAsync<T>(T @object)
        {
            var broker = new StorageBroker(this._configuration);
            broker.Entry(@object).State = EntityState.Added;
            await broker.SaveChangesAsync();

            return @object;
        }

        private IQueryable<T> SelectAll<T>() where T : class
        {
            var broker = new StorageBroker(this._configuration);

            return broker.Set<T>();
        }

        private async ValueTask<T> SelectAsync<T>(params object[] objectIds) where T : class
        {
            var broker = new StorageBroker(this._configuration);

            return await broker.FindAsync<T>(objectIds);
        }

        private async ValueTask<T> UpdateAsync<T>(T @object)
        {
            var broker = new StorageBroker(this._configuration);
            broker.Entry(@object).State = EntityState.Modified;
            await broker.SaveChangesAsync();

            return @object;
        }

        private async ValueTask<T> DeleteAsync<T>(T @object)
        {
            var broker = new StorageBroker(this._configuration);
            broker.Entry(@object).State = EntityState.Deleted;
            await broker.SaveChangesAsync();

            return @object;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                this._configuration.GetConnectionString(name: "DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
