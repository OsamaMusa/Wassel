using Domain.Entities;
using Domain.Entities.Base;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace Domain.IServices
{
    [ScopedService]
    public interface ILocationService  : IGeneralService<LocationVM,Location>
    {
      

    }
}
