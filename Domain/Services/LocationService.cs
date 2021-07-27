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

namespace Domain.Services
{

    public class LocationService  : GeneralService<LocationVM, Location>, ILocationService
    {
        IRepository<Location> _repository;
        IMapper _mapper;


        public LocationService(IRepository<Location> repository, IMapper mapper) : base(repository,mapper)
        {

            _repository = repository;
            _mapper = mapper;


        }

    }
}
