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

namespace Wassel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private readonly IPackagesService _services;
        private readonly IMapper _mapper;


        public PackagesController(IPackagesService service, IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }

        // GET: api/Items
        [HttpGet]
        public async Task<List<PackageVM>> GetItem()
        {
            return await _services.GetAll();
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
        public async Task<PackageVM> GetItem(long id)
        {

            return await _services.GetItem(new ParentEntityVM() { ID = id });

        }

        // PUT: api/Items/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<PackageVM> PutItem(PackageVM item)
        {

            return await _services.Update(item);

        }

        // POST: api/Items
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PackageVM>> PostItem(PackageVM item)
        {
            return await _services.Insert(item);

        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteItem(long id)
        {
            return await _services.delete(new ParentEntityVM() { ID = id});
        }

      
    }
}
