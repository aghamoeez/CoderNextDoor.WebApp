using CoderNextDoor.Data;
using CoderNextDoor.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository
{
    public class TagRepository : Repository<Tag>, ITagRepository
    {
        private readonly ApplicationDbContext _db;

        public TagRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetTagListForDropDown()
        {
            throw new NotImplementedException();
        }

        public void Update(Tag post)
        {
            throw new NotImplementedException();
        }
    }
}