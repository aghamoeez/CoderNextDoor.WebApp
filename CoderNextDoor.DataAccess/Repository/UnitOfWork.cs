using CoderNextDoor.Data;
using CoderNextDoor.DataAccess.Repository.IRepository;

namespace CoderNextDoor.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Comment = new CommentRepository(_db);
            Tag = new TagRepository(_db);
            Post = new PostRepository(_db);
            User = new UserRepository(_db);
            SP_Call = new SP_Call(_db);
            Category = new CategoryRepository(_db);
        }

        //       public ICategoryRepository Category { get; private set; }
        //  public IFrequencyRepository Frequency { get; private set; }
        //      public IServiceRepository Service { get; private set; }
        //   public IOrderHeaderRepository OrderHeader { get; private set; }
        //    public IOrderDetailsRepository OrderDetails { get; private set; }
        public IUserRepository User { get; private set; }

        public ICommentRepository Comment { get; private set; }
        public ITagRepository Tag { get; private set; }
        public IPostRepository Post { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public ICategoryRepository Category { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}