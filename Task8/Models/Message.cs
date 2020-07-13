using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task8.Models
{
    public class Message
    {
        public int Id { get; set; }
        public MessageType Type { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public enum MessageType
        {
            Info,
            Warning,
            Error
        }
    }

    
}