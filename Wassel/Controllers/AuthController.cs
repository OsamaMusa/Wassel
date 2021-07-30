using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Model;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Wassel.IAuth;

namespace Wassel.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _services;
        private readonly IMapper _mapper;

        public AuthController(IAuthService services, IMapper mapper)
        {
            _services = services;
            _mapper = mapper;
        }


        // POST: api/Cars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [AllowAnonymous]
        [HttpGet]
        public IActionResult GetUser(String userName,String password)
        {
            var result = _services.Authentication(userName, password);
            if (result != null)
                return Ok(result);
            return BadRequest();

        }
        
        [AllowAnonymous]
        [HttpPost]
        public IActionResult AddUser(UserVM user)
        {
            var result = _services.AddUserAsync(user);
            if (result != null)
                return Ok(result);
            return NotFound();

        }
        
    }
}
