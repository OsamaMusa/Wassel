using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.Contexts;
using Domain.Entities;
using Domain.IServices;
using AutoMapper;
using Domain.Model;
using Domain.Model.Base;
using Microsoft.AspNetCore.Authorization;

namespace Wassel.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _services;
        private readonly IMapper _mapper;


        public LocationsController(ILocationService service, IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }

        // GET: api/Locations
        [HttpGet]
        public async Task<List<LocationVM>> GetLocation()
        {
            return await _services.GetAll();
        }

        // GET: api/Locations/5
        [HttpGet("{id}")]
        public async Task<LocationVM> GetLocation(long id)
        {

            return await _services.GetItem(new ParentEntityVM() { ID = id });
        }

        // PUT: api/Locations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<LocationVM> PutLocation(LocationVM location)
        {

            return await _services.Update(location);

        }

        // POST: api/Locations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LocationVM>> PostLocation(LocationVM location)
        {
            return await _services.Insert(location);

        }

        // DELETE: api/Locations/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteLocation(long id)
        {
            return await _services.delete(new ParentEntityVM() { ID = id });

        }

    }
}
