namespace CSharpPractice
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Entity> Entities { get; set; }
        public virtual DbSet<EntityTweetLink> EntityTweetLinks { get; set; }
        public virtual DbSet<EntityType> EntityTypes { get; set; }
        public virtual DbSet<Tweet> Tweets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tweet>()
                .HasMany(e => e.EntityTweetLinks)
                .WithRequired(e => e.Tweet)
                .WillCascadeOnDelete(false);
        }
    }
}
