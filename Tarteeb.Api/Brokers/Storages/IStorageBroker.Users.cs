﻿using System.Linq;
using System.Threading.Tasks;
using System;
using Tarteeb.Api.Models.Teams;
using Tarteeb.Models.Users;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial interface IStorageBroker_Users
    {
        ValueTask<User> InsertUserAsync(User user);
        IQueryable<User> SelectAllUser();
        ValueTask<User> SelectUserById(Guid id);
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<User> DeleteUserAsync(User user);
    }
}

