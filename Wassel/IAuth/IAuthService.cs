using Domain.Entities;
using Domain.IServices;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace Wassel.IAuth
{
    [ScopedService]
    public interface IAuthService : IGeneralService<UserVM, User>
    {
        public string Authentication(String username, String password);
        public Task<string> AddUserAsync(UserVM user);
    }
}
