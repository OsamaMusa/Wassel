using Data.Contexts;
using Domain.Entities.Base;
using Domain.IReporsitory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class Repository<T>: IRepository<T> where T : EntityBase
    {
        WasselAppContext _wasselAppContext;
        public Repository(WasselAppContext wasselAppContext)
        {

            _wasselAppContext = wasselAppContext;
        }
        public async Task<T> Insert(T item) 
        {
            var _table = _wasselAppContext.Set<T>();
            await _table.AddAsync(item);
            await _wasselAppContext.SaveChangesAsync();
            return item;
        }
        public async Task<T> Remove(T item)
        {
            var _table = _wasselAppContext.Set<T>();
            _table.Remove(item);
            await _wasselAppContext.SaveChangesAsync();
            return item;
        }
        public async Task<IEnumerable<T>> RemoveRange(IEnumerable<T> item)
        {
            var _table = _wasselAppContext.Set<T>();
            _table.RemoveRange(item);
            await _wasselAppContext.SaveChangesAsync();
            return item;
        }
        public async Task<T> update(T item)
        {
            var _table = _wasselAppContext.Set<T>();
            _table.Update(item);
            await _wasselAppContext.SaveChangesAsync();
            return item;
        }
        public async Task<IEnumerable<T>> UpdateRange(IEnumerable<T> item)
        {
            var _table = _wasselAppContext.Set<T>();
            _table.UpdateRange(item);
            await _wasselAppContext.SaveChangesAsync();
            return item;
        }
        public async Task<T> Find(EntityBase keyValues)
        {
            var _table = _wasselAppContext.Set<T>();
            return await _table.FindAsync(keyValues.ID);

        }
        public IQueryable<T> Get()
        {
            var _table = _wasselAppContext.Set<T>();
            return _table.AsQueryable();

        }

        public async Task<IEnumerable<T>> RemoveRange(IQueryable<T> item)
        {
            var _table = _wasselAppContext.Set<T>();
            _table.RemoveRange(item);
            await _wasselAppContext.SaveChangesAsync();
            return item;
        }
    }
}
