//=================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to bring order in your workplace
//===============================

using Microsoft.AspNetCore.Mvc;
using Tarteeb.Api.Brokers.Storages;

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
    }
}