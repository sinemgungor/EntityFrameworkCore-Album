using DAL.Context;
using DAL.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class CRUD<T> : ICRUD<T> where T : BaseEntity
    {
        public CRUD(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _table=_dbContext.Set<T>();
        }

        AppDbContext _dbContext;
        DbSet<T> _table;
        public bool Add(T entity)
        {
            _table.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            _table.Remove(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public T Find(int id)
        {
            return _table.Find(id);
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public bool Update(T entity)
        {
            _table.Update(entity);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
