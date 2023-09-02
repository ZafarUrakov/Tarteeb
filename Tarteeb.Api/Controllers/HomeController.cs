//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarteeb.Api.Brokers.Storages;
using Local = Tarteeb.Api.Models.Tasks;

namespace Tarteeb.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IStorageBroker storageBroker;

        public HomeController(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        [HttpGet]
        public ActionResult<string> GetMessage() => "Tarteeb is Working";

        [HttpPost]
        public async ValueTask<ActionResult> PostTaskAsync()
        {
            var task = new Local.Task
            {
                Id = Guid.NewGuid()
            };
            var addedTask = await this.storageBroker.InsertTaskAsync(task);
            
            return Ok(addedTask);
        }
    }
}