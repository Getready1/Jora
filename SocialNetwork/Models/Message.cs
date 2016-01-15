using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public string Text { get; set; }
        public User Sender { get; set; }
        public User Reciever { get; set; }
        public Song SharedSong { get; set; }
    }
}