using CoderNextDoor.Data;
using CoderNextDoor.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository
{
    public class UserRepository : IRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _db;

        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void LockUser(string userId)
        {
            var userFromDb = _db.Users.FirstOrDefault(u => u.Id == userId);
            userFromDb.LockoutEnd = DateTime.Now.AddYears(1000);
            _db.SaveChanges();
        }

        public void UnLockUser(string userId)
        {
            var userFromDb = _db.Users.FirstOrDefault(u => u.Id == userId);
            userFromDb.LockoutEnd = DateTime.Now;
            _db.SaveChanges();
        }

        public Task<User> CreateAsync(User obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> CreateRangeAsync(IEnumerable<User> objs)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> FindAsync(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User obj)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IEnumerable<User> objs)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll(Expression<Func<User, bool>> filter = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public User GetFirstOrDefault(Expression<Func<User, bool>> filter = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetUserListForDropDown()
        {
            throw new NotImplementedException();
        }

        public void LockUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void UnLockUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }
    }
}