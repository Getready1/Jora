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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}