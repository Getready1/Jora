using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.Models.EntityModels
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