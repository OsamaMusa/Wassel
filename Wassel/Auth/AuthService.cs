using AutoMapper;
using Domain.Entities;
using Domain.IReporsitory;
using Domain.IServices;
using Domain.Model;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Wassel.IAuth;

namespace Wassel.Auth
{
    public class AuthService : GeneralService<UserVM, User>, IAuthService
    {
        IRepository<User> _repository;
        IMapper _mapper;
        private List<UserVM> users = new List<UserVM>();
        public AuthService(IRepository<User> repository, IMapper mapper) : base(repository, mapper)
        {

            _repository = repository;
            _mapper = mapper;
            this.key = "this is my custom Secret key for authnetication";
            var itemE = _repository.Get().ToList();
            if (itemE.Count > 0)
                this.users = _mapper.Map<List<UserVM>>(itemE);

        }

        private readonly string key;

        public string Authentication(string username, string password)
        {
            password = EncoderPass(password);
            if (users.Count < 1 || !users.Any(u => u.userName == username && u.password == password))
                return null;
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
               {
                   new Claim(ClaimTypes.Name, username)
               }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }


        public async Task<string> AddUserAsync(UserVM user)
        {
            user.password = EncoderPass(user.password);
            await _repository.Insert(_mapper.Map<User>(user));
            return "User Added !!";

        }

        private string EncoderPass(string pass)
        {
            if (String.IsNullOrEmpty(pass)) return "";
            pass += this.key;
            var result = Encoding.UTF8.GetBytes(pass);
            return Convert.ToBase64String(result);

        }

    }

}
