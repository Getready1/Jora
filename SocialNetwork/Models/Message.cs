using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace SocialNetwork.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public string Text { get; set; }
        public virtual User Sender { get; set; }
        public virtual User Reciever { get; set; }
        public virtual Song SharedSong { get; set; }
    }

    public class MessageConfiguration : EntityTypeConfiguration<Message>
    {
        public MessageConfiguration()
        {
            HasKey(m => m.MessageId);
            Property(m => m.Text).IsRequired();
        }
    }
}