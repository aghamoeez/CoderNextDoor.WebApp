using CoderNextDoor.Data;
using CoderNextDoor.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private readonly ApplicationDbContext _db;

        public CommentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetArticleListForDropDown()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetCommentListForDropDown()
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}