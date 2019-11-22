using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRNotificationHub.Hubs;
using SignalRNotificationHub.Models;

namespace SignalRNotificationHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotifyController : ControllerBase
    {
        private readonly IHubContext<NotificationHub> notificationHub;
        public NotifyController(IHubContext<NotificationHub> notificationHub)
        {
            this.notificationHub = notificationHub;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Success here!");
        }

        [HttpPost]
        public async Task<IActionResult> NotifyAll([FromBody]Message msg)
        {
            msg.clientid = "100";
            msg.date = DateTime.Now;

            await notificationHub.Clients.All.SendAsync("BroadcastMessage", msg.type, msg.message);

            return Accepted(msg.clientid, msg); 
        }
    }
}