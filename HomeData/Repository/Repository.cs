using HomeData.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;

namespace HomeData.Repository
{
    public class Repository<T> where T : class
    {
        public HomeDbContext Context { get; set; }
        public DbSet<T> Table { get; set; }
        public Repository(HomeDbContext context)
        {
            Context = context;
            Table = Context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return  Table.ToList();
        }

        public T GetSingle(Guid id)
        {
            return  Table.Find(id);
        }

        public int Save(T model)
        {
             Table.AddAsync(model);
            return  Context.SaveChanges();
        }

        public int Save(IEnumerable<T> models)
        {
             Table.AddRangeAsync(models);
            return  Context.SaveChanges();
        }

        public int Update(T model)
        {
            Context.Update(model);
            return  Context.SaveChanges();
        }

        public int Update(IEnumerable<T> models)
        {
            Context.UpdateRange(models);
            return  Context.SaveChanges();
        }

    }
}
