//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using System;
using System.Linq;
using System.Threading.Tasks;
using Local = Tarteeb.Api.Models.Tasks;
namespace Tarteeb.Api.Brokers.Storages;

public partial interface IStorageBroker_Tasks
{
    ValueTask<Local.Task> InsertTaskAsync(Local.Task task);
    IQueryable<Local.Task> SelectAllTask();
    ValueTask<Local.Task> SelectTaskById(Guid id);
    ValueTask<Local.Task> UpdateTaskAsync(Local.Task student);
    ValueTask<Local.Task> DeleteTaskAsync(Local.Task task);
}