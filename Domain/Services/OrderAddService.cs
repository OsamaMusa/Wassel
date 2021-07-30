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

    public class OrderAddService  : GeneralService<OrderAddVM, Order> , IOrderAddService
    {
        IRepository<Order> _repository;
        IMapper _mapper;


        public OrderAddService(IRepository<Order> repository, IMapper mapper) : base(repository,mapper)
        {

            _repository = repository;
            _mapper = mapper;


        }

    }
}
