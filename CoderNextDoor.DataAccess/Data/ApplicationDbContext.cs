using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoderNextDoor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Post> Post { get; set; }

        #region CommentRelatedDBSet

        public DbSet<Comment> Comment { get; set; }
        //public DbSet<PostComment> PostComment { get; set; }

        #endregion CommentRelatedDBSet

        #region TagRelatedDBSet

        public DbSet<PostTag> TagPost { get; set; }
        public DbSet<Tag> Tag { get; set; }

        #endregion TagRelatedDBSet

        #region CategoryRelatedDBSet

        public DbSet<Category> Category { get; set; }

        #endregion CategoryRelatedDBSet
    }
}