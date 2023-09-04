﻿//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using System;

namespace Tarteeb.Api.Models.Tasks
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? AssigneeId { get; set; }
        public Priority Priority { get; set; }
        public DateTimeOffset Deadline { get; set; }
        public TaskStatus Status { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
        public Guid GreatedUserId { get; set; }
        public Guid UpdatedUserId { get; set; }
    }
}
