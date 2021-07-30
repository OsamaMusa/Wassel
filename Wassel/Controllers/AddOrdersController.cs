using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Domain.IServices;
using AutoMapper;
using Domain.Model;
using Microsoft.AspNetCore.Authorization;

namespace Wassel.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AddOrdersController : ControllerBase
    {
        private readonly IOrderAddService _services;
        private readonly IMapper _mapper;


        public AddOrdersController(IOrderAddService service, IMapper mapper)
        {
            _services = service;
            _mapper = mapper;
        }

        // GET: api/Orders
      

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<OrderAddVM> PutOrder( OrderAddVM order)
        {

            return await _services.Update(order);
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderAddVM>> PostOrder(OrderAddVM order)
        {
            return await _services.Insert(order);

        }


    }
}
