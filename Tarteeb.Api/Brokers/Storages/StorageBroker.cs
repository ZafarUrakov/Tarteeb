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
    public partial class StorageBroker : EFxceptionsContext,IStorageBroker
    {
        private readonly IConfiguration _configuration;

        public StorageBroker(IConfiguration configuration)
        {
            _configuration = configuration;
            this.Database.Migrate();
        }

        public async ValueTask<T> InsertAsync<T>(T @object)
        {
            var broker = new StorageBroker(this._configuration);
            broker.Entry(@object).State = EntityState.Added;
            await broker.SaveChangesAsync();
            return @object;

        }

        public async ValueTask<T> DeleteAsync<T>(T @object)
        {
            var broker = new StorageBroker(this._configuration);
            broker.Entry(@object).State = EntityState.Deleted;
            await broker.SaveChangesAsync();
            return @object;

        }

        public IQueryable<T> SelectAllAsync<T>() where T : class
        {
            var broker = new StorageBroker(this._configuration);
            return broker.Set<T>();
        }

        public async ValueTask<T> SelectByIdAsync<T>(params object[] objectIds) where T : class
        {
            var broker = new StorageBroker(this._configuration);
            return await broker.FindAsync<T>(objectIds);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = 
                this._configuration.GetConnectionString(name: "DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}