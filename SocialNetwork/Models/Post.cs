using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.Models
{
    public class Post
    {
        public Guid PostId { get; set; }
        public virtual Song PostedSong { get; set; }

        public virtual List<Message> Comments { get; set; }
    }

    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            HasKey(p => p.PostId);
        }
    }
}