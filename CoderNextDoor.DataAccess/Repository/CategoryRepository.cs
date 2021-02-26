using CoderNextDoor.Data;
using CoderNextDoor.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            throw new NotImplementedException();
        }

        public void Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}