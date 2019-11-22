using System;

namespace SignalRNotificationHub.Models
{
    public class Message
    {
        public string clientid { get; set; }
        public string type { get; set; }
        public string message { get; set; }
        public DateTime ?date { get; set; }
    }
}
