using CoderNextDoor.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CoderNextDoor.DataAccess.Repository
{
    ///// <summary>
    ///// EF implementation of a base repository for commonly used data access methods.
    ///// </summary>
    ///// <typeparam name="T">It is a sub type of <see cref="Entity"/> which provides an int based PK.</typeparam>
    ///// <remarks>
    ///// The sub class will have its specific methods, for example SqlCategoryRepository and SqlTagRepository
    ///// has a GetListAsync() which does their specific join.
    ///// </remarks>
    //public class Repository<T> : IRepository<T> where T : Entity
    //{
    //    /// <summary>
    //    /// The set initialized by sub class.
    //    /// </summary>
    //    protected readonly DbContext Context;
    //    internal DbSet<T> dbSet;

    //    /// <summary>
    //    /// The specific context initialized by sub class.
    //    /// </summary>
    //  //  private readonly ApplicationDbContext _db;

    //    public Repository(DbContext context)
    //    {
    //        Context = context;
    //        this.dbSet = context.Set<T>();
    //        //  isSqlite = _db.Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite";
    //    }

    //    /// <summary>
    //    /// Creates an entity and returns a tracked object with id.
    //    /// </summary>
    //    /// <param name="entity"></param>
    //    /// <returns>The <paramref name="entity"/> with id.</returns>
    //    /// <exception cref="FanException">
    //    /// Throws if insert violates unique key constraint. See <see cref="https://stackoverflow.com/a/47465944/32240"/>
    //    /// </exception>
    //    public virtual async Task<T> CreateAsync(T entity)
    //    {
    //        try
    //        {
    //            await dbSet.AddAsync(entity);
    //            await Context.SaveChangesAsync();
    //            return entity;
    //        }
    //        catch (DbUpdateException dbUpdEx)
    //        {
    //            throw new Exception(); //GetExceptionForUniqueConstraint(dbUpdEx);
    //        }
    //        catch (Exception e) {
    //            throw new Exception();
    //        }
    //    }

    //    /// <summary>
    //    /// Creates a list of entities.
    //    /// </summary>
    //    /// <param name="entities"></param>
    //    /// <returns></returns>
    //    public virtual async Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> entities)
    //    {
    //        dbSet.AddRange(entities);
    //        await Context.SaveChangesAsync();
    //        return entities;
    //    }

    //    /// <summary>
    //    /// Deletes an entity.
    //    /// </summary>
    //    /// <param name="id">The integer id of the entity.</param>
    //    public virtual async Task DeleteAsync(int id)
    //    {
    //        var entity = await dbSet.SingleAsync(e => e.Id == id);
    //        dbSet.Remove(entity);
    //        await Context.SaveChangesAsync();
    //    }

    //    public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    /// <summary>
    //    /// Returns a list of objects of T based on search predicate.
    //    /// </summary>
    //    /// <param name="predicate"></param>
    //    /// <returns></returns>
    //    /// <remarks>
    //    /// Suitable when predicate is very simple and short.  If you take a look at
    //    /// SqlTagRepository GetListAsync() that is not suitable for this.
    //    /// </remarks>
    //    //public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate) =>
    //    //    Context ?
    //    //        _entities.ToList().Where(predicate.Compile()).ToList() :
    //    //        await _entities.Where(predicate).ToListAsync();

    //    //public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
    //    //{
    //    //    throw new NotImplementedException();
    //    //}

    //    /// <summary>
    //    /// Returns an object by id, returns null if not found.
    //    /// </summary>
    //    /// <param name="id"></param>
    //    /// <returns></returns>
    //    public virtual async Task<T> GetAsync(int id) => await dbSet.SingleOrDefaultAsync(e => e.Id == id);

    //    public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    /// <summary>
    //    /// Updates an entity.
    //    /// </summary>
    //    /// <param name="entity">
    //    /// The entity to be updated, the EF implementation does not use this parameter.
    //    /// </param>
    //    /// <exception cref="FanException">
    //    /// Throws if update violates unique key constraint.
    //    /// </exception>
    //    public virtual async Task UpdateAsync(T entity)
    //    {
    //        try
    //        {
    //            await Context.SaveChangesAsync();
    //        }
    //        catch (DbUpdateException dbUpdEx)
    //        {
    //            throw new Exception(); //GetExceptionForUniqueConstraint(dbUpdEx);
    //        }
    //    }

    //    /// <summary>
    //    /// Updates a list of entities.
    //    /// </summary>
    //    /// <param name="entities">
    //    /// The entities to be updated, the EF implementation does not use this parameter.
    //    /// </param>
    //    /// <returns></returns>
    //    public virtual async Task UpdateAsync(IEnumerable<T> entities)
    //    {
    //        await Context.SaveChangesAsync();
    //    }

    //    private Exception GetExceptionForUniqueConstraint(DbUpdateException dbUpdEx)
    //    {
    //        //if (dbUpdEx.InnerException != null)
    //        //{
    //        //    var message = dbUpdEx.InnerException.Message;
    //        //    if (message.Contains("UniqueConstraint", StringComparison.OrdinalIgnoreCase)
    //        //        || message.Contains("Unique Constraint", StringComparison.OrdinalIgnoreCase))
    //        //        return new FanException(EExceptionType.DuplicateRecord, dbUpdEx);

    //        //    if (dbUpdEx.InnerException.InnerException != null)
    //        //    {
    //        //        message = dbUpdEx.InnerException.InnerException.Message;
    //        //        if (message.Contains("UniqueConstraint", StringComparison.OrdinalIgnoreCase)
    //        //            || message.Contains("Unique Constraint", StringComparison.OrdinalIgnoreCase))
    //        //            return new FanException(EExceptionType.DuplicateRecord, dbUpdEx);
    //        //    }
    //        //}

    //        return new Exception();
    //    }
    //}

    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        internal DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            Context = context;
            this.dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            try
            {
                dbSet.Add(entity);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public Task<T> CreateAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> objs)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            //include properties will be comma seperated
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }

        public Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            //include properties will be comma seperated
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
            T entityToRemove = dbSet.Find(id);
            Remove(entityToRemove);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public Task UpdateAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IEnumerable<T> objs)
        {
            throw new NotImplementedException();
        }
    }
}