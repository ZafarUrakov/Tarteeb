//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using Microsoft.EntityFrameworkCore;
using Tarteeb.Models.Users;

namespace Tarteeb.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<User> Users { get; set; }
    }
}