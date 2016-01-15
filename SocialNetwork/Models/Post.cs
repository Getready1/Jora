using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.Models
{
    public class Post
    {
        public Guid PostId { get; set; }
        public virtual Song PostedSong { get; set; }

        public virtual List<Message> Comments { get; set; }
    }
}