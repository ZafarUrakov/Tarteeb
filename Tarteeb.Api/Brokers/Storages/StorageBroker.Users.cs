﻿//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System;
using Tarteeb.Models.Users;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<User> Users { get; set; }

        public async ValueTask<User> InsertUserAsync(User user) =>
            await InsertAsync(user);
        public IQueryable<User> SelectAllUser() =>
            SelectAll<User>();
        public async ValueTask<User> SelecUserById(Guid id) =>
            await SelectAsync<User>(id);
        public async ValueTask<User> UpdateUserAsync(User user) =>
          await UpdateAsync(user);
        public async ValueTask<User> DeleteUserAsync(User user) =>
            await DeleteAsync(user);

    }
}