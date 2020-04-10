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
    public class Product : IProduct
    {
        public string Desc { get => "My Product"; set => Desc = value; }
        public string Name { get => "Product1"; set => Name = value; }
    }
}
