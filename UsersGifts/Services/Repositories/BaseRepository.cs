namespace UsersGiftsRegistryTask.Services.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    using UsersGiftsRegistryTask.Services.Database;
    using UsersGiftsRegistryTask.Models;

    public class BaseRepository<T> where T : BaseEntity
    {
        private DbContext Context { get; set; }
        private DbSet<T> DbSet { get; set; }

        public BaseRepository()
        {
            this.Context = new WinFormsTaskDbContext();
            this.DbSet = this.Context.Set<T>();
        }

        public virtual List<T> GetAll()
        {
            return this.DbSet.ToList();
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return this.DbSet.Where(filter).ToList();
        }

        public virtual T Get(Expression<Func<T, bool>> filter)
        {
            return this.DbSet.FirstOrDefault(filter);
        }

        public virtual T GetById(int id)
        {
            return this.DbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
            this.DbSet.Add(entity);
            this.Context.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            this.Context.Entry(entity).State = EntityState.Modified;
            this.Context.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            this.DbSet.Remove(entity);
            this.Context.SaveChanges();
        }
    }
}
