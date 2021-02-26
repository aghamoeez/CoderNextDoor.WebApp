using System;

namespace CoderNextDoor.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        ICommentRepository Comment { get; }
        ITagRepository Tag { get; }
        IPostRepository Post { get; }

        ISP_Call SP_Call { get; }

        ICategoryRepository Category { get; }

        void Save();
    }
}