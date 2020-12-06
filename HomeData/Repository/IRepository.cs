using HomeData.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeData.Repository
{
    public interface IRepository<T> where T : class
    {
        public HomeDbContext Context { get; set; }
        public DbSet<T> Table { get; set; }
        IEnumerable<T> GetAll();
        T GetSingle(Guid id);
        int Save(T model);
        int Update(T model);
        int Save(IEnumerable<T> models);
        int Update(IEnumerable<T> models);
    }
}
