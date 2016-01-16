using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.Models.EntityModels
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Text { get; set; }
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