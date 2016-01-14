using SocialNetwork.Models;
using System.Data.Entity;

namespace SocialNetwork.DAL
{
    public class Context : DbContext, IContext
    {
        public Context()
            : base("name=LocalDb")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public IDbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
        }
    }
}