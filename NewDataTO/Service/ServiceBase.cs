﻿using Microsoft.EntityFrameworkCore;
using NewDataTO.Model;

namespace Repository.Service
{
    public class ServiceBase<T> where T : class
    {
        protected DbSet<T> _dbSet;
        private OtherOtherDatabaseContext _context;

        public ServiceBase()
        {
            _context = new OtherOtherDatabaseContext();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public bool Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception or log it
                return false;
            }
        }

        public bool AddMany(IEnumerable<T> entities)
        {

            _dbSet.BulkInsert(entities);
            return true;
        }

        public bool Remove(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception or log it
                return false;
            }
        }
        public bool Update(T entity)
        {
            try
            {
                var tracker = _context.Attach(entity);
                tracker.State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception or log it
                return false;
            }
        }
        public List<T> SearchByKeyword(Func<T, bool> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }
    }
}
