using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IReporsitory
{
    public interface IRepository<T> where T : EntityBase
    {
        Task<T> Insert(T item);
        Task<T> Remove(T item);
        Task<IEnumerable<T>> RemoveRange(IEnumerable<T> item);
        Task<IEnumerable<T>> RemoveRange(IQueryable<T> item);
        Task<T> update(T item);
        Task<IEnumerable<T>> UpdateRange(IEnumerable<T> item);
        Task<T> Find(EntityBase keyValues);
        IQueryable<T> Get();

    }
}
