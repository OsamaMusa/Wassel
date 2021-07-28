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
using Domain.Model;
using Domain.Entities;
using Domain.Model.Base;

namespace Domain.Services
{

    public class OrderService  : GeneralService<OrderVM, Order> , IOrderService
    {
        IRepository<Order> _repository;
        IMapper _mapper;


        public OrderService(IRepository<Order> repository, IMapper mapper) : base(repository,mapper)
        {

            _repository = repository;
            _mapper = mapper;


        }
        public async Task<List<OrderVM>> GetAll()
        {
            var itemE = await _repository.Get().Include(c => c.Package)
                .ThenInclude(d=>d.PackageItems)
                .ToListAsync();
            return _mapper.Map<List<OrderVM>>(itemE);
        }
        
        public async Task<OrderVM> GetItem(ParentEntityVM keyValues)
        {
          
            return  GetAll().Result.Find(e => e.ID == keyValues.ID);
        }

    }
}
