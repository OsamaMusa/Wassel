using AutoMapper;
using Domain.Entities.Base;
using Domain.IServices;
using Domain.IReporsitory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.IServices;
using System.Threading.Tasks;
using Domain.Model;
using Domain.Entities;

namespace Domain.Services
{

    public class CarService  : GeneralService<CarVM, Car> , ICarService
    {
        IRepository<Car> _repository;
        IMapper _mapper;


        public CarService(IRepository<Car> repository, IMapper mapper) : base(repository,mapper)
        {

            _repository = repository;
            _mapper = mapper;


        }

    }
}
