using System;
using System.Data.Entity.ModelConfiguration;

namespace SocialNetwork.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }

    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            HasKey(u => u.UserId);
            Property(u => u.FirstName).IsRequired();
            Property(u => u.LastName).IsRequired();
            Property(u => u.Password).IsRequired();
        }
    }
}