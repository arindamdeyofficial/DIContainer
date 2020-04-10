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
    public class TypedProduct<T> : IProduct<T>
        where T:new()
    {
        private T _prd = new T();

        public string Desc { get => typeof(T).GetProperty("Desc").GetValue(_prd).ToString(); set => Desc = value; }
        public string Name { get => typeof(T).GetProperty("Name").GetValue(_prd).ToString(); set => Name = value; }

    }
}
