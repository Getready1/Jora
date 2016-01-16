using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.Models
{
    public class Follow
    {
        public int FollowId { get; set; }
    }

    public class FollowConfiguration : EntityTypeConfiguration<Follow>
    {
        public FollowConfiguration()
        {
            HasKey(u => u.FollowId);
        }
    }
}