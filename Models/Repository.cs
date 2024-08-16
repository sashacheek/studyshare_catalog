﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FinalProject.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected  FinalProjectContext context {  get; set; }
        private DbSet<T> dbset {  get; set; }

        public Repository(FinalProjectContext ctx) {
            context = ctx;
            dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> List(QueryOptions<T> options) => BuildQuery(options).ToList();

        public virtual T? Get(int id) => dbset.Find(id);
        public virtual T? Get(QueryOptions<T> options) =>
    BuildQuery(options).FirstOrDefault();
        public virtual void Insert(T entity) => dbset.Add(entity);
        public virtual void Update(T entity) => dbset.Update(entity);
        public virtual void Delete(T entity) => dbset.Remove(entity);
        public virtual void Save() => context.SaveChanges();

        private IQueryable<T> BuildQuery(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
            {
                query = query.Where(options.Where);
            }
            //if (options.HasOrderBy)
            //{
            //    if (options.OrderByDirection == "asc")
            //        query = query.OrderBy(options.OrderBy);
            //    else
            //        query = query.OrderByDescending(options.OrderBy);
            //}
            //if (options.HasPaging)
            //{
            //    query = query.PageBy(options.PageNumber, options.PageSize);
            //}

            return query;
        }

        private IQueryable<T> BuildQuery()
        {
            IQueryable<T> query = dbset;

            //if (options.HasWhere)
            //{
            //    query = query.Where(options.Where);
            //}
            //if (options.HasOrderBy)
            //{
            //    if (options.OrderByDirection == "asc")
            //        query = query.OrderBy(options.OrderBy);
            //    else
            //        query = query.OrderByDescending(options.OrderBy);
            //}
            //if (options.HasPaging)
            //{
            //    query = query.PageBy(options.PageNumber, options.PageSize);
            //}

            return query;
        }
    }
}
