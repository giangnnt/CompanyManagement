using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class RepositoryBase<T> where T : class
    {
        CompanyManagementContext _context;
        DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new CompanyManagementContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var tracker = _context.Attach<T>(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }
    }
}
