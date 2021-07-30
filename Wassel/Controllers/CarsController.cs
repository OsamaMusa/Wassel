using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.Contexts;
using Domain.Model;
using Domain.IServices;
using Domain.Entities.Base;
using Domain.Entities;
using AutoMapper;
using Domain.Model.Base;
using Domain.IReporsitory;
using Microsoft.AspNetCore.Authorization;

namespace Wassel.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _services;
        private readonly IMapper _mapper ;
      
        public CarsController(ICarService services,IMapper mapper )
        {
            _services = services;
            _mapper = mapper;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<List<CarVM>> GetCars()
        {
            return await _services.GetAll();
        }
        
        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarVM>> GetCar(long id)
        {

            return await _services.GetItem(new ParentEntityVM() { ID = id});

        }
        
        // PUT: api/Cars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<CarVM> PutCar(CarVM car)
        {

            return await _services.Update(car);
        }
        
        // POST: api/Cars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarVM>> PostCar(CarVM car)
        {

            return await _services.Insert(car);
        }
        
        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteCar(long id)
        {
            return await _services.delete(new ParentEntityVM() { ID = id });
        }
        

    }
}
