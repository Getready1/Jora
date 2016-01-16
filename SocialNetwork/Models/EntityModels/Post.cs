using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.Models.EntityModels
{
    public class Post
    {
        public int PostId { get; set; }
    }

    public class PostConfiguration : EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            HasKey(p => p.PostId);
        }
    }
}