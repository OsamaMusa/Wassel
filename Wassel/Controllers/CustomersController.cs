using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.Contexts;
using Domain.Entities;
using AutoMapper;
using Domain.IServices;
using Domain.Model;
using Domain.Model.Base;

namespace Wassel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _services;
        private readonly IMapper _mapper;


        public CustomersController(ICustomerService service,IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<List<CustomerVM>> GetCustomers()
        {
            return await _services.GetAll();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<CustomerVM> GetCustomer(long id)
        {

            return await _services.GetItem(new ParentEntityVM() { ID = id });

        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<CustomerVM> PutCustomer( CustomerVM customer)
        {

            return await _services.Update(customer);

        }

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerVM>> PostCustomer(CustomerVM customer)
        {

            return await _services.Insert(customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteCustomer(long id)
        {
            return await _services.delete(new ParentEntityVM() { ID = id });
        }

    }
}
