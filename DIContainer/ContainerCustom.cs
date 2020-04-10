using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DIContainer
{
    public class ContainerCustom<T, U>
        where U:T, new()
    {
        public U ResolveType()
        {
            return (U)Activator.CreateInstance(typeof(U));
        }
    }
}
