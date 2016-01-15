using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialNetwork.Models
{
    public class Follow
    {
        public Guid FollowId { get; set; }
        public virtual User Follower { get; set; }
        public virtual User Followed { get; set; }
    }
}