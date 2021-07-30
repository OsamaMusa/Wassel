using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _services;
        private readonly IMapper _mapper;


        public OrdersController(IOrderService service, IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<List<OrderVM>> GetOrders()
        {
            return await _services.GetAll();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<OrderVM> GetOrder(long id)
        {

            return await _services.GetItem(new ParentEntityVM() { ID = id });
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<OrderVM> PutOrder(OrderVM order)
        {

            return await _services.Update(order);
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderVM>> PostOrder(OrderVM order)
        {
            return await _services.Insert(order);

        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<bool> DeleteOrder(long id)
        {

            return await _services.delete(new ParentEntityVM() { ID = id });

        }
        
    

    }
}
