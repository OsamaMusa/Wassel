using AutoMapper;
using Domain.Entities.Base;
using Domain.IServices;
using Domain.IReporsitory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Base;

namespace Domain.Services
{
    public class GeneralService<M, E> : IGeneralService<M, E> where E : EntityBase
    {
        IRepository<E> _repository;
        IMapper _mapper;
        public GeneralService(IRepository<E> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<bool> delete(ParentEntityVM keyValues)
        {
            var itemQ = _repository.Get().Where(e => e.ID == keyValues.ID);
            await _repository.RemoveRange(itemQ);
            return true;
        }

        public async Task<M> GetItem(ParentEntityVM keyValues)
        {
            var itemE = await _repository.Find(_mapper.Map<EntityBase>(keyValues));
            return _mapper.Map<M>(itemE);
        }

        public async Task<List<M>> GetAll()
        {
            var itemE = await _repository.Get().ToListAsync();
            return _mapper.Map<List<M>>(itemE);
        }

        public async Task<M> Insert(M itemM)
        {

            var itemE = _mapper.Map<E>(itemM);
            await _repository.Insert(itemE);
            return _mapper.Map<M>(itemE);
        }

        public async Task<M> Update( M itemM)
        {
            var itemE = _mapper.Map<E>(itemM);
            await _repository.update(itemE);
            return _mapper.Map<M>(itemE);
        }

    

    }
}
