using Domain.Entities.Base;
using Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace Domain.IServices
{
    [ScopedService]
    public interface IGeneralService<M, E> where E : EntityBase
    {
        Task<List<M>> GetAll();
        Task<M> GetItem(ParentEntityVM ID);
        Task<M> Insert(M Item);
        Task<M> Update(M Item);
        Task<bool> delete(ParentEntityVM ID);

    }
}
